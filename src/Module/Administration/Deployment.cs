// =============================================================================
// Outpost31.Module.Administration.Deployment.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250905_code
// u250905_documentation
// =============================================================================

using System;
using System.IO;
using System.Reflection;
using Outpost31.Core.Avatar;
using Outpost31.Core.Framework;
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
        public static void Deploy(Folders folders, string baseWwwFolder, string baseDataFolder, string appDataFolder, int traceLogLimit)
        {
            //LogEvent.Trace(2, traceLimit, avatarSystem, ExeAsmName, 0);

            CreateFolderFramework(folders, traceLogLimit);
            RefreshAppData(baseWwwFolder, appDataFolder, traceLogLimit);
        }

        /// <summary>Create the Tingen Web Service folder framework.</summary>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/></param>
        internal static void CreateFolderFramework(Folders folders, int traceLogLimit)
        {
            //LogEvent.Trace(2, traceLogLimit, avatarSystem, ExeAsmName, 0);

           

            Outpost31.Core.Framework.Folders.CreateFolderFramework(folders, traceLogLimit);

            //var assembly = Assembly.GetExecutingAssembly();

            //string folderFramwork;

            //var folderFrameworkFile = "Outpost31.AppData.Blueprint.Embedded.framework-folder.emblueprint";

            //using (Stream folderFrameworkStream = assembly.GetManifestResourceStream(folderFrameworkFile))
            //{
            //    File.WriteAllText($@"{baseDataFolder}\Missing file", "E39635");
            //    if (folderFrameworkStream == null)
            //    {
            //        File.WriteAllText($@"{baseDataFolder}\Missing folder framework file", "E39635");
            //        return;
            //    }

            //    using (StreamReader reader = new StreamReader(folderFrameworkStream))
            //    {
            //        folderFramwork = reader.ReadToEnd();
            //    }
            //}

            //foreach (var folder in folderFramwork.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            //{
            //    Directory.CreateDirectory($@"{baseDataFolder}\{folder}");
            //}
        }

        /// <summary>Refresh application data that is required by the Tingen Web Service.</summary>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/></param>
        public static void RefreshAppData(string baseWwwFolder, string appDataFolder, int traceLogLimit)
        {
            //LogEvent.Trace(2, traceLimit, avatarSystem, ExeAsmName, 0);

            // TODO - This doesn't work right. You need to run this a few times to get all the files copied.
            var source = $@"{baseWwwFolder}\bin\AppData";
            var target = appDataFolder;

            if (Directory.Exists(target))
            {
                Directory.Delete(target, true);
            }

            Directory.CreateDirectory(target);

            CopyDirectory(source, target);
        }

        /// TODO move to a utility class
        internal static void CopyDirectory(string source, string target)
        {
            // No logging here, would generate too much stuff.

            // Ensure the destination directory exists
            Directory.CreateDirectory(target);

            // Copy all files
            foreach (string file in Directory.GetFiles(source))
            {
                string destFile = Path.Combine(target, Path.GetFileName(file));
                File.Copy(file, destFile, true); // Overwrite if file exists
            }

            // Recursively copy subdirectories
            foreach (string subDir in Directory.GetDirectories(source))
            {
                string destSubDir = Path.Combine(target, Path.GetFileName(subDir));
                CopyDirectory(subDir, destSubDir);
            }
        }
    }
}
