// =============================================================================
// Outpost31.Core.Admin.Deployment.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250829_code
// u250829_documentation
// =============================================================================

using System;
using System.IO;
using System.Reflection;
using Outpost31.Core.Avatar;

namespace Outpost31.Core.Admin
{
    /// <summary>Logic for deployment processes.</summary>
    /// <remarks>For more information about Outpost31, please see the <see cref="ProjectInfo"/> file.</remarks>
    public class Deployment
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Deploy the Tingen Web Service framework.</summary>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/></param>
        public static void Deploy(string avatarSystem)
        {
            CreateFolderFramework(avatarSystem);
            RefreshAppData(avatarSystem);
            Testing.GenerateAppLogs(avatarSystem, 1000);
        }

        /// <summary>Create the Tingen Web Service folder framework.</summary>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/></param>
        internal static void CreateFolderFramework(string avatarSystem)
        {
            var assembly = Assembly.GetExecutingAssembly();

            string folderFramwork;

            using (Stream folderFrameworkStream = assembly.GetManifestResourceStream("Outpost31.AppData.Blueprint.framework-folder.embp"))
            {
                if (folderFrameworkStream == null)
                {
                    // TODO - Note about writing logs to _undefined.
                    File.WriteAllText($@"C:\Tingen_Data\WebService\{avatarSystem}\_undefined\Cannot find embedded framework file", "E39635");
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
        public static void RefreshAppData(string avatarSystem)
        {
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