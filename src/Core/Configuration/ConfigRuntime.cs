/* Outpost31.Core.ConfigRuntime.cs
 * u250625_code
 * u250625_documentation
 */


using System;
using Outpost31.Core.Logger;

namespace Outpost31.Core.Runtime
{
    /// <summary>Runtime configuration logic.</summary>
    /// <remarks>TBD.</remarks>
    /// <seealso href="https://github.com/spectrum-health-systems/Tingen-Documentation">Tingen documentation</seealso>
    public class ConfigRuntime
    {
        /// <summary>The current version of the Tingen Web Service.</summary>
        public string WsvcVer { get; set; }

        /// <summary>The current build number of the Tingen Web Service.</summary>
        public string WsvcBuild { get; set; }

        /// <summary>The Avatar <see cref="Outpost31.Core.Avatar.AvtrSystemInfo.AvtrSys"/>  System that the Tingen Web Service will interface with.</summary>
        public string AvtrSys { get; set; }

        /// <summary>The Tingen Web Service mode.</summary>
        public string WsvcMode { get; set; }

        /// <summary>The Tingen Web Service data path.</summary>
        public string WsvcDataPath { get; set; }

        /// <summary>The name of the machine running the Tingen Web Service.</summary>
        public string WsvcHostName { get; set; }

        /// <summary>The current date in YYMMDD format.</summary>
        public string CurrentDate { get; set; }

        /// <summary>The current time in HHMMSS format.</summary>
        public string CurrentTime { get; set; }

        public static ConfigRuntime New(string wsvcVer, string avtrSys)
        {
            LogEvent.Debuggler(avtrSys, "[Outpost31.Core.Runtime.Configuration.Runtime.New()]");

            return new ConfigRuntime
            {
                WsvcVer      = wsvcVer,
                WsvcBuild    = "250624.0852",
                AvtrSys      = avtrSys,
                WsvcMode     = null,
                WsvcDataPath = $@"C:\Tingen_Data\WebService\{avtrSys}\Data",
                WsvcHostName = Environment.MachineName,
                CurrentDate  = DateTime.Now.ToString("yyMMdd"),
                CurrentTime  = DateTime.Now.ToString("HHmmss")
            };
        }
    }
}