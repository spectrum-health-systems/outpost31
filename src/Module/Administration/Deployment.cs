// =============================================================================
// Outpost31.Module.Administration.Deployment.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250903_code
// u250903_documentation
// =============================================================================

using System;
using System.IO;
using System.Reflection;
using Outpost31.Core.Avatar;
using Outpost31.Core.Logger;

namespace Outpost31.Module.Administration
{
    /// <summary>Administrative deployment functionality.</summary>
    internal class Deployment
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Deploy the Tingen Web Service framework.</summary>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/></param>
        public static void FullDeploy(string avatarSystem, int traceLimit)
        {
            LogAppEvent.Trace(2, traceLimit, avatarSystem, ExeAsmName, 0);

            CreateFolderFramework(avatarSystem, traceLimit);
            RefreshAppData(avatarSystem, traceLimit);
            Testing.GenerateAppLogs(avatarSystem, traceLimit, 1000);
        }

        /// <summary>Create the Tingen Web Service folder framework.</summary>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/></param>
        internal static void CreateFolderFramework(string avatarSystem, int traceLimit)
        {
            LogAppEvent.Trace(2, traceLimit, avatarSystem, ExeAsmName, 0);

            var assembly = Assembly.GetExecutingAssembly();

            string folderFramwork;

            var folderFrameworkFile = @"Outpost31.AppData.EmbeddedBlueprint.Framework.framework.folder";

            using (Stream folderFrameworkStream = assembly.GetManifestResourceStream(folderFrameworkFile))
            {
                if (folderFrameworkStream == null)
                {
                    File.WriteAllText($@"C:\Tingen_Data\WebService\{avatarSystem}\Missing folder framework file", "E39635");
                    return;
                }

                using (StreamReader reader = new StreamReader(folderFrameworkStream))
                {
                    folderFramwork = reader.ReadToEnd();
                }
            }

            foreach (var folder in folderFramwork.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                Directory.CreateDirectory($@"C:\Tingen_Data\WebService\{avatarSystem}\{folder}");
            }
        }

        /// <summary>Refresh application data that is required by the Tingen Web Service.</summary>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/></param>
        public static void RefreshAppData(string avatarSystem, int traceLimit)
        {
            LogAppEvent.Trace(2, traceLimit, avatarSystem, ExeAsmName, 0);

            // TODO - This doesn't work right. You need to run this a few times to get all the files copied.
            var source = $@"C:\Tingen_www\WebService\{avatarSystem}\bin\AppData";
            var target = $@"C:\Tingen_Data\WebService\{avatarSystem}\AppData";

            if (Directory.Exists(target))
            {
                Directory.Delete(target, true);
            }

            Directory.CreateDirectory(target);

            CopyDirectory(source, target);
        }

        /// TODO move to a utility class
        internal static void CopyDirectory(string sourceDir, string destinationDir)
        {
            // No logging here, would generate too much stuff.

            // Ensure the destination directory exists
            Directory.CreateDirectory(destinationDir);

            // Copy all files
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destinationDir, Path.GetFileName(file));
                File.Copy(file, destFile, true); // Overwrite if file exists
            }

            // Recursively copy subdirectories
            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = Path.Combine(destinationDir, Path.GetFileName(subDir));
                CopyDirectory(subDir, destSubDir);
            }
        }
    }
}
