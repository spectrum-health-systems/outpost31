// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                               Core.Configuration.TngnConfig.cs

// u250410_code
// u250410_documentation

using System;
using Outpost31.Core.Runtime;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Configuration
{
    /// <summary>Runtime setting logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/ClassDescription/*'/>
    public partial class TngnWbsvConfiguration
    {
        /* Class properties are defined in the ScriptParameter.Properties.cs partial class. */

        /// <summary>Load the runtime settings for the Tingen Web Service.</summary>
        /// <param name="tngnVersion">The Tingen Web Service version</param>
        /// <returns>Runtime settings for the Tingen Web Service.</returns>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/Load/*'/>
        public static TngnWbsvConfiguration New(string tngnVersion)
        {
            RuntimeSettings runtimeSetting = RuntimeSettings.New();

            return new TngnWbsvConfiguration()
            {
                TngnWbsvVersion    = tngnVersion,
                TngnWbsvBuild      = runtimeSetting.TngnWbsvBuild,
                //TngnSystemCode = DuFile.ReadAndVerifyLocal(runtimeSetting.SystemCode, cat_ValidSystemCodes()),
                //TngnMode       = DuFile.ReadAndVerifyLocal(runtimeSetting.TngnMode, cat_ValidTngnModes()),
                TngnWbsvHostName   = Environment.MachineName,
                TngnWbsvDataPath   = DuFile.ReadLocal(runtimeSetting.TngnWbsvDataPath),
                CurrentDate    = runtimeSetting.CurrentDate,
                CurrentTime    = runtimeSetting.CurrentTime
            };
        }

        /// <summary>The summary of the Tingen Web Service configuration at runtime.</summary>
        /// <return>A summary of the Tingen Web Service configuration at runtime.</return>
        private static string ConfigSummary(TngnWbsvConfiguration tngnConfig) =>
            $"----------------------------------------{Environment.NewLine}" +
            $"Tingen Web Service runtime configuration{Environment.NewLine}" +
            $"----------------------------------------{Environment.NewLine}" +
            $"    Version: {tngnConfig.TngnWbsvVersion}{Environment.NewLine}" +
            $"      Build: {tngnConfig.TngnWbsvBuild}{Environment.NewLine}" +
            $"System Code: {tngnConfig.TngnWbsvEnvironment}{Environment.NewLine}" +
            $"       Mode: {tngnConfig.TngnWbsvMode}{Environment.NewLine}" +
            $"       Date: {tngnConfig.CurrentDate}{Environment.NewLine}" +
            $"       Time: {tngnConfig.CurrentTime}" +
            $"   Hostname: {tngnConfig.TngnWbsvHostName}{Environment.NewLine}";
    }
}