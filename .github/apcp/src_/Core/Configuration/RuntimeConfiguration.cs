/* Outpost31.Core.RuntimeConfig.cs
 * u250822_code
 * u250822_documentation
 */

using System;
using System.IO;
using Outpost31.Core.Logger;

namespace Outpost31.Core.Runtime
{
    /// <summary>Runtime configuration logic.</summary>
    /// <remarks>
    ///     The runtime configuration contains information about the current instance/session of the Tingen Web Service<br/>
    ///     that is not specific to <i>core</i> or <i>module</i> functionality.
    ///     <br/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='ProjectInfo/Class[@name="Project"]/Callback/*'/>
    /// </remarks>
    public class RuntimeConfiguration
    {
        /// <summary>The current version of the Tingen Web Service.</summary>
        public string TngnWsvcVer { get; set; }

        /// <summary>The current build number of the Tingen Web Service.</summary>
        public string TngnWsvcBuild { get; set; }

        /// <summary>The Avatar <see cref="Outpost31.Core.Avatar.AvtrSystem.AvtrSys"/>  System that the Tingen Web Service will interface with.</summary>
        public string AvtrSys { get; set; }

        /// <summary>The Tingen Web Service mode.</summary>
        public string TngnWsvcMode { get; set; }

        /// <summary>The Tingen Web Service data path.</summary>
        public string TngnWsvcDataPath { get; set; }

        /// <summary>The name of the machine running the Tingen Web Service.</summary>
        public string TngnWsvcHostName { get; set; }

        /// <summary>The current date in YYMMDD format.</summary>
        public string CurrentDate { get; set; }

        /// <summary>The current time in HHMMSS format.</summary>
        public string CurrentTime { get; set; }

        /// <summary>Loads the runtime configuration for a Tingen Web Service session.</summary>
        /// <remarks>
        /// </remarks>
        /// <param name="tngnWsvcVer">The current version of the Tingen Web Service.</param>
        /// <param name="avtrSys">The Avatar System that the Tingen Web Service interfaces with.</param>
        /// <returns>The runtime configuration for a Tingen Web Service session.</returns>
        public static RuntimeConfiguration Load(string tngnWsvcVer, string avtrSys, string tngnWsvcDataPath, string runtimeConfigPath)
        {
            var runtimeConfigFile = $@"{tngnWsvcDataPath}\{runtimeConfigPath}";

            RuntimeConfiguration rt = Utility.Du.DuJson.ImportFromFile<RuntimeConfiguration>(runtimeConfigFile);

            rt.TngnWsvcVer = tngnWsvcVer;

            return rt;

            //return new RuntimeConfiguration
            //    {
            //        TngnWsvcVer      = tngnWsvcVer,
            //        TngnWsvcBuild    = "250822",
            //        AvtrSys      = avtrSys,
            //        TngnWsvcMode     = null,
            //        TngnWsvcDataPath = $@"C:\Tingen_Data\WebService\{avtrSys}\Data",
            //        TngnWsvcHostName = Environment.MachineName,
            //        CurrentDate  = DateTime.Now.ToString("yyMMdd"),
            //        CurrentTime  = DateTime.Now.ToString("HHmmss")
            //};
        }

        public static void VerifyExists(string avtrSys)
        {
            var runtimeConfigPath = $@"C:\Tingen_Data\WebService\{avtrSys}\App\Runtime\TngnWsvc.RuntimeConfig";

            if (!File.Exists(runtimeConfigPath))
            {
                LogEvent.Critical(avtrSys, $"Runtime configuration file not found at {runtimeConfigPath}", "Runtime configuration not found");

                WriteBlank(runtimeConfigPath, avtrSys);
            }
        }

        /// <summary>Writes a blank runtimeConfig file.</summary>
        /// <param name="runtimeConfigPath"></param>
        internal static void WriteBlank(string runtimeConfigPath, string avtrSys)
        {
            LogEvent.Critical(avtrSys, $"{runtimeConfigPath}", "Runtime 1");

            RuntimeConfiguration runtimeConfig = new RuntimeConfiguration
            {
                TngnWsvcVer      = "set-at-runtime",
                TngnWsvcBuild    = "unknown",
                AvtrSys          = "set-at-runtime",
                TngnWsvcMode     = "unknown",
                TngnWsvcDataPath = "uknown",
                TngnWsvcHostName = "unkown",
                CurrentDate      = "set-at-runtime",
                CurrentTime      = "set-at-runtime",
            };

            LogEvent.Critical(avtrSys, $"{runtimeConfig}", "Runtime 2");

            Utility.Du.DuJson.ExportToFile(runtimeConfig, runtimeConfigPath);
        }
    }
}