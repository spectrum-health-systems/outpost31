/* Outpost31.Core.Blueprint.LogTemplate.cs
 * u250804_code
 * u250804_documentation
 */

using System.IO;
using Outpost31.Core.Runtime;

namespace Outpost31.Core.Blueprint
{
    /// <summary>Blueprints for log details.</summary>
    public static class LogTemplate
    {


        /// <summary>The summary of the Tingen Web Service configuration at runtime.</summary>
        /// <return>A summary of the Tingen Web Service configuration at runtime.</return>
        public static string RuntimeConfig(RuntimeConfiguration runtimeConfig)
        {
            var tinplate = File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Tinplate\Log\detail-runtime-configuration.tinplate");

            return $"{LogContent.BasicHeader()}" +
                    tinplate.Replace("~DateTime~", $"{runtimeConfig.CurrentDate}-{runtimeConfig.CurrentDate}")
                            .Replace("~WsvcVer~", runtimeConfig.TngnWsvcVer)
                            .Replace("~WsvcBuild~", runtimeConfig.TngnWsvcBuild)
                            .Replace("~AvtrSys~", runtimeConfig.AvtrSys)
                            .Replace("~WsvcMode~", runtimeConfig.TngnWsvcMode)
                            .Replace("~WsvcDataPath~", runtimeConfig.TngnWsvcDataPath)
                            .Replace("~WsvcHostName~", runtimeConfig.TngnWsvcHostName);
        }
    }
}