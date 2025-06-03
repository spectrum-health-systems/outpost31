/* Core
 * ███ █ █ ███ ███ ███ ███  ███ ███ ██
 * █ █ █ █  █  ███ █ █ ████  █   ██  █
 * ███ ███  █  █   ███  ███  █  ███  █
 * Configuration.TngnWbsvConfiguration.cs

/* u250603_code
 * u250603_documentation
 */

using System.IO;
using System.Text.Json;
using Outpost31.Core.Logger;

namespace Outpost31.Core.Configuration
{
    /// <summary>Runtime setting logic for the Tingen Web Service.</summary>
    /// <remarks>
    ///     <note title="About this class">
    ///         This class handles all configuration logic for the Tingen Web Service.<br/>
    ///         <list type="bullet">
    ///             <item>Should not be used in production</item>
    ///             <item>Is most likely super ugly</item>
    ///             <item>Probably doesn't follow best practices</item>
    ///         </list>
    ///     </note>
    /// </remarks>
    /// <seealso href="https://github.com/spectrum-health-systems/Tingen-Documentation">Tingen documentation</seealso>
    public class TngnWbsvConfiguration
    {
        public string TraceLevel { get; set; }

        /// <summary>Load the runtime settings for the Tingen Web Service.</summary>
        /// <param name="tngnWbsvVersion">The Tingen Web Service version</param>
        /// <returns>Runtime settings for the Tingen Web Service.</returns>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnWbsvConfiguration"]/ClassDescription/*'/>
        public static TngnWbsvConfiguration New(string tngnWbsvEnvironment)
        {
            LogEvent.Debuggler(tngnWbsvEnvironment, $"[LOAD NEW CONFIG]");

            return new TngnWbsvConfiguration();
        }

        public static void CreateDefault(string tngnWbsvEnvironment)
        {
            LogEvent.Debuggler(tngnWbsvEnvironment, $"[CREATE DEFAULT CONFIG]");

            var tngnWbsvConfig = new TngnWbsvConfiguration()
            {
                TraceLevel = "0"
            };

            LogEvent.Debuggler(tngnWbsvEnvironment, $@"[WRITE DEFAULT CONFIG] '{tngnWbsvConfig.TraceLevel}'- C:\Tingen_Data\WebService\{tngnWbsvEnvironment}\Configs\TngnWbsv.config");


            var st = JsonSerializer.Serialize(tngnWbsvConfig, new JsonSerializerOptions
            {
                WriteIndented = true
            });

            File.Create($@"C:\Tingen_Data\WebService\{tngnWbsvEnvironment}\Configs\TngnWbsv.config").Close();

            File.WriteAllText($@"C:\Tingen_Data\WebService\{tngnWbsvEnvironment}\Configs\TngnWbsv.config", st);

            //DuJson.ExportToLocalFile<TngnWbsvConfiguration>(tngnWbsvConfig, $@"C:\Tingen_Data\WebService\{tngnWbsvEnvironment}\Configs\TngnWbsv.config", false);

            LogEvent.Debuggler(tngnWbsvEnvironment, $@"[WRITE DEFAULT CONFIG B]");
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