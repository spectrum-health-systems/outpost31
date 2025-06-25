/* Outpost31.Core.Blueprint.LogDetailBprt.cs
 * u250625_code
 * u250625_documentation
 */

using System.IO;
using Outpost31.Core.Runtime;

namespace Outpost31.Core.Blueprint
{
    /// <summary>Blueprints for log details.</summary>
    public class LogDetailBprt
    {
        /// <summary>The summary of the Tingen Web Service configuration at runtime.</summary>
        /// <return>A summary of the Tingen Web Service configuration at runtime.</return>
        public static string RuntimeConfig(ConfigRuntime runtimeConfig)
        {
            var tinplate = File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Tinplate\Log\detail-runtime-configuration.tinplate");

            return $"{LogHeaderBprt.BasicHeader()}" +
                    tinplate.Replace("~DateTime~", $"{runtimeConfig.CurrentDate}-{runtimeConfig.CurrentDate}")
                            .Replace("~WsvcVer~", runtimeConfig.WsvcVer)
                            .Replace("~WsvcBuild~", runtimeConfig.WsvcBuild)
                            .Replace("~AvtrSys~", runtimeConfig.AvtrSys)
                            .Replace("~WsvcMode~", runtimeConfig.WsvcMode)
                            .Replace("~WsvcDataPath~", runtimeConfig.WsvcDataPath)
                            .Replace("~WsvcHostName~", runtimeConfig.WsvcHostName);
        }
    }
}