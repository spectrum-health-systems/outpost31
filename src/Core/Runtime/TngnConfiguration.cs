//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██

// u250404_code
// u250404_documentation

// Ignore Spelling: Tngn

using System;

using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Runtime
{
    /// <summary>Runtime setting logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/ClassDescription/*'/>
    public partial class TngnConfiguration
    {
        /// <summary>Load the runtime settings for the Tingen Web Service.</summary>
        /// <param name="tngnVersion">The Tingen Web Service version</param>
        /// <returns>Runtime settings for the Tingen Web Service.</returns>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/Load/*'/>
        public static TngnConfiguration Load(string tngnVersion)
        {
            TngnConfiguration tngnConfig = new TngnConfiguration();

            tngnConfig.TngnVersion          = tngnVersion;
            tngnConfig.TngnBuild            = DuFile.ReadLocal(tngnConfig.RequiredFiles["TngnBuild"]);
            tngnConfig.TngnSystemCode       = DuFile.ReadAndVerifyLocal(tngnConfig.RequiredFiles["TngnSystemCode"], tngnConfig.ValidSystemCodes);
            tngnConfig.TngnMode             = DuFile.ReadAndVerifyLocal(tngnConfig.RequiredFiles["TngnMode"], tngnConfig.ValidTngnModes);
            tngnConfig.TngnHostName         = Environment.MachineName;
            tngnConfig.TngnHostDataPath     = DuFile.ReadLocal(tngnConfig.RequiredFiles["TngnDataPath"]);
            tngnConfig.DateStamp            = DateTime.Now.ToString("YYMMDD");
            tngnConfig.TimeStamp            = DateTime.Now.ToString("HHMMSS");
            tngnConfig.RequiredDirectories  = cat_RequiredDirectories(tngnConfig.TngnHostDataPath);
            tngnConfig.RequiredFiles        = cat_RequiredFiles(tngnConfig.TngnHostDataPath);
            tngnConfig.ValidSystemCodes     = cat_ValidSystemCodes();
            tngnConfig.ValidTngnModes       = cat_ValidTngnModes();
            tngnConfig.ConfigurationSummary = RuntimeConfigSummary(tngnConfig);

            return tngnConfig;
        }
    }
}