// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                               Core.Configuration.TngnConfig.cs

// u250430_code
// u250430_documentation

using System;
using System.IO;
using Outpost31.Core.Runtime;

namespace Outpost31.Core.Configuration
{
    /// <summary>Runtime setting logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnWbsvConfiguration"]/ClassDescription/*'/>
    public class TngnWbsvConfiguration
    {
        public TngnWbsvRuntimeSettings tngnWbsvRuntimeSettings { get; set; }

        ///// <summary>A summary of the runtime settings for exporting.</summary>
        //public string tngnWbsvConfigSummary { get; set; }

        /// <summary>Load the runtime settings for the Tingen Web Service.</summary>
        /// <param name="tngnWbsvVersion">The Tingen Web Service version</param>
        /// <returns>Runtime settings for the Tingen Web Service.</returns>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnWbsvConfiguration"]/ClassDescription/*'/>
        public static TngnWbsvConfiguration New()
        {
            return new TngnWbsvConfiguration();
        }

        /// <summary>The summary of the Tingen Web Service configuration at runtime.</summary>
        /// <return>A summary of the Tingen Web Service configuration at runtime.</return>
        public static void TngnWbsvConfigSummary(TngnWbsvConfiguration tngnWbsvConfig, string path)
        {
            var currentConfig = "Coming soon";

            File.WriteAllText(path, currentConfig);
        }
    }
}