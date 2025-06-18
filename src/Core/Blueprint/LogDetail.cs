/* Outpost31.Core.Blueprint.LogDetail.cs
 * u250618_code
 * u250618_documentation
 */

using System;
using Outpost31.Core.Runtime;

namespace Outpost31.Core.Blueprint
{
    public class LogDetail
    {
        /// <summary>The summary of the Tingen Web Service configuration at runtime.</summary>
        /// <return>A summary of the Tingen Web Service configuration at runtime.</return>
        public static string Runtime(WsvcRuntime tngnWbsvRuntimeSettings)
        {
            return $"========================================{Environment.NewLine}" +
                   $"Tingen Web Service - Runtime Details{Environment.NewLine}" +
                   $"========================================{Environment.NewLine}" +
                   $"Updated {DateTime.Now:MM/dd/yyyy HH:mm:ss}{Environment.NewLine}" +
                   $"------------------------------------{Environment.NewLine}" +
                   $"Version:     {tngnWbsvRuntimeSettings.TngnWsvcVer}{Environment.NewLine}" +
                   $"Build:       {tngnWbsvRuntimeSettings.TngnWsvcBuild}{Environment.NewLine}" +
                   $"Environment: {tngnWbsvRuntimeSettings.TngnWsvcAvtrSys}{Environment.NewLine}" +
                   $"Mode:        {tngnWbsvRuntimeSettings.TngnWsvcMode}{Environment.NewLine}" +
                   $"Data Path:   {tngnWbsvRuntimeSettings.TngnWsvcDataPath}{Environment.NewLine}" +
                   $"Host Name:   {tngnWbsvRuntimeSettings.TngnWsvcHostName}{Environment.NewLine}" +
                   $"{Environment.NewLine}" +
                   "To update this information, launch the \"Web Service Testing\" form.";
        }
    }
}
