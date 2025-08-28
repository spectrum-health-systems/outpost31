// =============================================================================
// Outpost31.Core.Admin.Deployment.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250828_code
// u250828_documentation
// =============================================================================

using System;
using System.IO;
using System.Reflection;
using Outpost31.Core.Avatar;

namespace Outpost31.Core.Admin
{
    /// <summary>Logic for deployment processes.</summary>
    /// <remarks>
    ///   For more information about Outpost31, please see the <see cref="ProjectInfo"/> file.
    /// </remarks>
    public class Deployment
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        public static void InitializeTngnWsvc(string avatarSystem)
        {
            var assembly = Assembly.GetExecutingAssembly();

            // Specify the full name of the embedded resource
            string resourceName = "Outpost31.AppData.Blueprint.Framework.framework.folder";

            string content;

            // Open the resource stream
            using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            {
                if (stream == null)
                {
                    File.WriteAllText(@"C:\IT\test.txt", "fail");
                    return;
                }

                // Read the resource content
                using (StreamReader reader = new StreamReader(stream))
                {
                    File.WriteAllText(@"C:\IT\test.txt", "yay");
                    content = reader.ReadToEnd();
                    File.WriteAllText(@"C:\IT\test2.txt", content);
                }
            }

            foreach (var folder in content.Split(new[] { '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries))
            {
                Directory.CreateDirectory($@"C:\Tingen_Data\WebService\{avatarSystem}\{folder}");
            }


            ///* For debugging only
            // */
            //LogEvent.Trace(avtrSys, ExeAsmName, $"");

            //var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "Outpost31.Core.DevDep.framework.folder";

            //Logger.LogEvent.Primeval(avtrSys, $"Regression test: Primeval log");


            ////var resourceName = "MyCompany.MyProduct.framework.folder";

            //string result;


            //using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            //using (StreamReader reader = new StreamReader(stream))
            //{
            //    result = reader.ReadToEnd();
            //}


            //var listr = result.ToList();

            ////var listr = File.ReadAllLines(avtrSys + @"\AppData\TngnWsvc\Blueprint\Framework\framework.folder").ToList();



            //foreach (var folder in listr)
            //{
            //    Directory.CreateDirectory($@"C:\Tingen_Data\WebService\{avtrSys}\AppData\TngnWsvc\Blueprint\Framework\{folder}");
            //}
        }

        /// <summary>Refresh application data that is required by the Tingen Web Service.</summary>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/></param>
        public static void RefreshAppData(string avatarSystem)
        {
            var targetAppDataPath = $@"C:\Tingen_Data\WebService\{avatarSystem}\AppData\";

            if (Directory.Exists(targetAppDataPath))
            {
                Directory.Delete(targetAppDataPath, true);
            }

            Directory.CreateDirectory(targetAppDataPath);

            CopyDirectory($@"C:\Tingen_www\WebService\{avatarSystem}\bin\AppData\", targetAppDataPath);
        }

        /// TODO move to a utility class
        internal static void CopyDirectory(string sourceDir, string destinationDir)
        {
            /* For debugging only
             */
            //LogEvent.Trace("", ExeAsmName, $"");

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