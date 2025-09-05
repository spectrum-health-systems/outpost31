// =============================================================================
// Outpost31.Core.Framework.Folders.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250905_code
// u250905_documentation
// =============================================================================

using System;
using System.Collections.Generic;
using System.IO;
using System.Reflection;

namespace Outpost31.Core.Framework
{
    /// <summary>
    /// Represents a set of folder paths used by the Outpost31 framework.
    /// </summary>
    public class Folders
    {
        /// <summary>
        /// Gets or sets the path to the system WWW folder.
        /// </summary>
        public string SystemWww { get; set; }

        /// <summary>
        /// Gets or sets the path to the system data folder.
        /// </summary>
        public string SystemData { get; set; }

        /// <summary>
        /// Gets or sets the path to the application data folder.
        /// </summary>
        public string AppData { get; set; }

        /// <summary>
        /// Gets or sets the path to the archive folder.
        /// </summary>
        public string Archive { get; set; }

        /// <summary>
        /// Gets or sets the path to the blueprint folder.
        /// </summary>
        public string Blueprint { get; set; }

        /// <summary>
        /// Gets or sets the path to the configuration folder.
        /// </summary>
        public string Config { get; set; }

        /// <summary>
        /// Gets or sets the path to the export folder.
        /// </summary>
        public string Export { get; set; }

        /// <summary>
        /// Gets or sets the path to the import folder.
        /// </summary>
        public string Import { get; set; }

        /// <summary>
        /// Gets or sets the path to the session folder.
        /// </summary>
        public string Session { get; set; }

        /// <summary>
        /// Loads folder paths based on provided parameters.
        /// </summary>
        /// <param name="systemDataFolder">The system data folder path.</param>
        /// <param name="systemWwwFolder">The system WWW folder path.</param>
        /// <param name="avatarUser">The avatar user name.</param>
        /// <param name="date">The date string.</param>
        /// <param name="time">The time string.</param>
        /// <returns>A <see cref="Folders"/> instance with initialized paths.</returns>
        internal static Folders Load(string systemDataFolder, string systemWwwFolder, string avatarUser, string date, string time)
        {
            return new Folders
            {
                SystemWww  = systemWwwFolder,
                SystemData = systemDataFolder,
                AppData    = $@"{systemDataFolder}\AppData",
                Archive    = $@"{systemDataFolder}\Archive",
                Blueprint  = $@"{systemDataFolder}\AppData\Blueprint",
                Config     = $@"{systemDataFolder}\Config",
                Export     = $@"{systemDataFolder}\Export",
                Import     = $@"{systemDataFolder}\Import",
                Session    = $@"{systemDataFolder}\Session\{date}\{avatarUser}\{time}"
            };
        }



        /// <summary>
        /// Creates the folder framework by ensuring all folders exist.
        /// </summary>
        /// <param name="folders">The <see cref="Folders"/> instance containing folder paths.</param>
        /// <param name="traceLogLimit">The trace log limit.</param>
        internal static void CreateFolderFramework(Folders folders, int traceLogLimit)
        {
            Type type = folders.GetType();

            foreach (PropertyInfo property in type.GetProperties())
            {
                if (!property.Name.ToLower().Contains("system"))
                {
                    File.AppendAllText($@"C:\Tingen_Data\folders.txt", $"{ Environment.NewLine}{property.Name}");
                    
                    if (!Directory.Exists(property.Name))
                    { 
                        Directory.CreateDirectory(property.Name); 
                    }
                        
                }
            }

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

        /// <summary>
        /// Creates the session folder if it does not exist.
        /// </summary>
        /// <param name="sessionFolder">The session folder path.</param>
        internal static void CreateSessionFolder(string sessionFolder)
        {
            if (!System.IO.Directory.Exists(sessionFolder))
            {
                System.IO.Directory.CreateDirectory(sessionFolder);
            }
        }

    }
}