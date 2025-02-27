//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███ 
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██ 
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██ 
//                 Outpost31.Core.Configuration.RuntimeSettings.cs
//                Runtime setting logic for the Tingen Web Service
// u250227_code
// u250227_documentation

using System;
using System.Collections.Generic;

using Outpost31.Core.Utilities.Du;

namespace Outpost31.Core.Configuration
{
    /// <summary>Runtime setting logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Configuration.xml' path='Core.Configuration/Class[@name="RuntimeSettings"]/RuntimeSettings/*'/>
    public class RuntimeSettings
    {
        /// <summary>The Tingen Web Service version.</summary>
        public string TngnVersion { get; set; }

        /// <summary>The Tingen Web Service build.</summary>
        public string TngnBuild { get; set; }

        /// <summary>The Tingen Web Service System Code.</summary>
        public string TngnSystemCode { get; set; }

        /// <summary>The Tingen Web Service build.</summary>
        public string TngnMode { get; set; }

        /// <summary>The current date.</summary>
        public string DateStamp { get; set; } = DateTime.Now.ToString("YYMMDD");

        /// <summary>The current time.</summary>
        public string TimeStamp { get; set; } = DateTime.Now.ToString("HHMMSS");

        /// <summary>Directories required by the Tingen Web Service.</summary>
        /// <include file='AppData/XmlDoc/Core.Configuration.xml' path='Core.Configuration/Class[@name="RuntimeSettings"]/RequiredDirectories/*'/>
        public Dictionary<string, string> RequiredDirectories { get; set; }

        /// <summary>Files required by the Tingen Web Service.</summary>
        /// <include file='AppData/XmlDoc/Core.Configuration.xml' path='Core.Configuration/Class[@name="RuntimeSettings"]/RequiredFiles/*'/>
        public Dictionary<string, string> RequiredFiles { get; set; } = new Dictionary<string, string>
        {
                { "TngnBuild", @"./AppData/Runtime/tngn.build" },
                { "TngnMode", @"./AppData/Runtime/tgng.mode" },
                { "TngnSystemCode", @"./AppData/Runtime/tgng.systemcode" }
        };

        /// <summary>Folders required by the Tingen Web Service.</summary>
        /// <include file='AppData/XmlDoc/Core.Configuration.xml' path='Core.Configuration/Class[@name="RuntimeSettings"]/RequiredFolders/*'/>
        public Dictionary<string, string> RequiredFolders { get; set; }

        /// <summary>The list of valid System Codes.</summary>
        /// <include file='AppData/XmlDoc/Core.Configuration.xml' path='Core.Configuration/Class[@name="RuntimeSettings"]/ValidSystemCodes/*'/>
        public List<string> ValidSystemCodes { get; set; } = new List<string>()
        {
            "LIVE",
            "UAT"
        };

        /// <summary>The list of valid Tingen Web Service modes.</summary>
        /// <include file='AppData/XmlDoc/Core.Configuration.xml' path='Core.Configuration/Class[@name="RuntimeSettings"]/ValidTngnModes/*'/>
        public List<string> ValidTngnModes { get; set; } = new List<string>()
        {
            "ENABLED",
            "DISABLED",
            "PASSTHROUGH"
        };

        /// <summary>Load the runtime settings for the Tingen Web Service.</summary>
        /// <param name="tngnVersion">The Tingen Web Service version</param>
        /// <returns>Runtime settings for the Tingen Web Service.</returns>
        /// /// <include file='AppData/XmlDoc/Core.Configuration.xml' path='Core.Configuration/Class[@name="RuntimeSettings"]/Load/*'/>
        public static RuntimeSettings Load(string tngnVersion)
        {
            RuntimeSettings runtimeSettings = new RuntimeSettings();

            runtimeSettings.TngnVersion    = tngnVersion;
            runtimeSettings.TngnBuild      = DuFile.ReturnContent(runtimeSettings.RequiredFiles["TngnBuild"]);
            runtimeSettings.TngnSystemCode = DuFile.ReturnVerifiedContent(runtimeSettings.RequiredFiles["TngnSystemCode"], runtimeSettings.ValidSystemCodes);
            runtimeSettings.TngnMode       = DuFile.ReturnContent(runtimeSettings.RequiredFiles["TngnMode"]);
            runtimeSettings.DateStamp      = DateTime.Now.ToString("yymmdd");
            runtimeSettings.TimeStamp      = DateTime.Now.ToString("HHMMSS");

            return runtimeSettings;
        }

        /// <summary>Verify the Tingen Web Service settings.</summary>
        /// <param name="runtimeSettings">The Tingen Session object.</param>
        /// <exception cref="Exception"></exception>
        /// <include file='AppData/XmlDoc/Core.Configuration.xml' path='Core.Configuration/Class[@name="RuntimeSettings"]/Verify/*'/>
        public static bool AreValid(RuntimeSettings runtimeSettings)
        {
            //TODO Test all of these conditions.
            if (!runtimeSettings.ValidTngnModes.Contains(runtimeSettings.TngnMode) ||
                !runtimeSettings.ValidSystemCodes.Contains(runtimeSettings.TngnSystemCode) ||
                !int.TryParse(runtimeSettings.TngnBuild, out int check))
            {
                return false;
                throw new Exception("Invalid TngnMode or TngnSystemCode");
            }
            else
            {
                return true;
            }
        }
    }
}