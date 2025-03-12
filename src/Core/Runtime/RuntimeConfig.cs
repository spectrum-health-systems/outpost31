//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//
// u250311_code
// u250311_documentation

using System;
using System.Collections.Generic;

using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Runtime
{
    /// <summary>Runtime setting logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="RuntimeConfig"]/RuntimeConfig/*'/>
    public class RuntimeConfiguration
    {
        /// <summary>The Tingen Web Service version.</summary>
        public string TngnVersion { get; set; }

        /// <summary>The Tingen Web Service build.</summary>
        public string TngnBuild { get; set; }

        /// <summary>The Tingen Web Service System Code.</summary>
        public string TngnSystemCode { get; set; }

        /// <summary>The Tingen Web Service mode.</summary>
        public string TngnMode { get; set; }

        /// <summary>The name of the machine running the Tingen Web Service.</summary>
        public string MachineName { get; set; } = Environment.MachineName;

        /// <summary>The current date.</summary>
        public string DateStamp { get; set; } = DateTime.Now.ToString("YYMMDD");

        /// <summary>The current time.</summary>
        public string TimeStamp { get; set; } = DateTime.Now.ToString("HHMMSS");

        /// <summary>Directories required by the Tingen Web Service.</summary>
        public Dictionary<string, string> RequiredDirectories { get; set; } = RuntimeCatalog.ReqDirs();

        /// <summary>Files required by the Tingen Web Service.</summary>
        public Dictionary<string, string> RequiredFiles { get; set; } = RuntimeCatalog.ReqFiles();

        /// <summary>The list of valid System Codes.</summary>
        public List<string> ValidSystemCodes { get; set; } = RuntimeCatalog.ValidSysCodes();

        /// <summary>The list of valid Tingen Web Service modes.</summary>
        public List<string> ValidTngnModes { get; set; } = RuntimeCatalog.ValidTngnModes();

        /// <summary>A summary of the runtime settings for exporting.</summary>
        public string RuntimeSummary { get; set; }

        /// <summary>Load the runtime settings for the Tingen Web Service.</summary>
        /// <param name="tngnVersion">The Tingen Web Service version</param>
        /// <returns>Runtime settings for the Tingen Web Service.</returns>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="RuntimeConfig"]/Load/*'/>
        public static RuntimeConfiguration Load(string tngnVersion)
        {
            RuntimeConfiguration runtimeConfig = new RuntimeConfiguration();

            runtimeConfig.TngnVersion    = tngnVersion;
            runtimeConfig.TngnBuild      = DuFile.GetContent(runtimeConfig.RequiredFiles["TngnBuild"]);
            runtimeConfig.TngnSystemCode = DuFile.GetVerifiedContent(runtimeConfig.RequiredFiles["TngnSystemCode"], runtimeConfig.ValidSystemCodes);
            runtimeConfig.TngnMode       = DuFile.GetVerifiedContent(runtimeConfig.RequiredFiles["TngnMode"], runtimeConfig.ValidTngnModes);
            runtimeConfig.RuntimeSummary = RuntimeCatalog.ConfigSummary(runtimeConfig);

            return runtimeConfig;
        }
    }
}