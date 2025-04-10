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
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnWbsvConfiguration"]/ClassDescription/*'/>
    public partial class TngnWbsvConfiguration
    {
        /* #DEVNOTE#
         * Since there are quite a few properties in the TngnWbsvConfiguration class, we will
         * define them in TngnWbsvConfiguration.Properties.cs. That way, the code is cleaner.
         */

        /// <summary>Load the runtime settings for the Tingen Web Service.</summary>
        /// <param name="tngnWbsvVersion">The Tingen Web Service version</param>
        /// <returns>Runtime settings for the Tingen Web Service.</returns>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnWbsvConfiguration"]/ClassDescription/*'/>
        public static TngnWbsvConfiguration New(string tngnWbsvVersion)
        {
            TngnWbsvConfiguration tngnWbsvConfig = new TngnWbsvConfiguration()
            {
                tngnWbsvRuntimeSettings = TngnWbsvRuntimeSettings.New(tngnWbsvVersion)
            };

            tngnWbsvConfig.tngnWbsvConfigSummary = TngnWbsvConfigSummary(tngnWbsvConfig);

            return tngnWbsvConfig;
        }

        /// <summary>The summary of the Tingen Web Service configuration at runtime.</summary>
        /// <return>A summary of the Tingen Web Service configuration at runtime.</return>
        private static string TngnWbsvConfigSummary(TngnWbsvConfiguration tngnWbsvConfig) =>
            $"--------------------------------{Environment.NewLine}" +
            $"Tingen Web Service configuration{Environment.NewLine}" +
            $"--------------------------------{Environment.NewLine}" +
            $"    Version: {tngnWbsvConfig.tngnWbsvRuntimeSettings.TngnWbsvVersion}{Environment.NewLine}" +
            $"      Build: {tngnWbsvConfig.tngnWbsvRuntimeSettings.TngnWbsvBuild}{Environment.NewLine}" +
            $"System Code: {tngnWbsvConfig.tngnWbsvRuntimeSettings.TngnWbsvEnv}{Environment.NewLine}" +
            $"       Mode: {tngnWbsvConfig.tngnWbsvRuntimeSettings.TngnWbsvMode}{Environment.NewLine}" +
            $"   Hostname: {tngnWbsvConfig.tngnWbsvRuntimeSettings.TngnWbsvHostName}{Environment.NewLine}" +
            $"       Date: {tngnWbsvConfig.tngnWbsvRuntimeSettings.CurrentDate}{Environment.NewLine}" +
            $"       Time: {tngnWbsvConfig.tngnWbsvRuntimeSettings.CurrentTime}";
    }
}