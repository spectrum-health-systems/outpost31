/////* Outpost31.Core.Runtime.Configuration.cs
/////* u250624_code
//// * u250624_documentation
//// */

////using System.IO;
////using System.Text.Json;
////using Outpost31.Core.Logger;

////namespace Outpost31.Core.Runtime
////{
////    public class CoreConfigd
////    {
////        public Runtime RuntimeConfig { get; set; } = new Runtime();
////        public Core CoreConfig { get; set; } = new Core();
////        public Module ModuleConfig { get; set; } = new Module();

////        /// <summary>Load the runtime settings for the Tingen Web Service.</summary>
////        /// <param name="tngnWbsvVersion">The Tingen Web Service version</param>
////        /// <returns>Runtime settings for the Tingen Web Service.</returns>
////        /// <include file='AppData/XMLDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnWbsvConfiguration"]/ClassDescription/*'/>
////        public static RuntimeConfig New(string tngnWbsvEnvironment)
////        {
////            LogEvent.Debuggler(tngnWbsvEnvironment, $"[LOAD NEW CONFIG]");

////            return new RuntimeConfig();
////        }

////        public static void CreateDefault(string tngnWbsvEnvironment)
////        {
////            LogEvent.Debuggler(tngnWbsvEnvironment, $"[CREATE DEFAULT CONFIG]");

////            var tngnWbsvConfig = new RuntimeConfig()
////            {
////                TraceLevel = "0"
////            };

////            LogEvent.Debuggler(tngnWbsvEnvironment, $@"[WRITE DEFAULT CONFIG] '{tngnWbsvConfig.TraceLevel}'- C:\Tingen_Data\WebService\{tngnWbsvEnvironment}\Configs\TngnWbsv.config");


////            var st = JsonSerializer.Serialize(tngnWbsvConfig, new JsonSerializerOptions
////            {
////                WriteIndented = true
////            });

////            File.Create($@"C:\Tingen_Data\WebService\{tngnWbsvEnvironment}\Configs\TngnWbsv.config").Close();

////            File.WriteAllText($@"C:\Tingen_Data\WebService\{tngnWbsvEnvironment}\Configs\TngnWbsv.config", st);

////            //DuJson.ExportToLocalFile<TngnWbsvConfiguration>(tngnWbsvConfig, $@"C:\Tingen_Data\WebService\{tngnWbsvEnvironment}\Configs\TngnWbsv.config", false);

////            LogEvent.Debuggler(tngnWbsvEnvironment, $@"[WRITE DEFAULT CONFIG B]");
////        }


////        /// <summary>The summary of the Tingen Web Service configuration at runtime.</summary>
////        /// <return>A summary of the Tingen Web Service configuration at runtime.</return>
////        public static void TngnWbsvConfigSummary(RuntimeConfig tngnWbsvConfig, string path)
////        {
////            var currentConfig = "Coming soon";

////            File.WriteAllText(path, currentConfig);
////        }
////    }
////}