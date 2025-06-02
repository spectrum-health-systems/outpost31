// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                       Core.Template.Details.cs

// u250602_code
// u250602_documentation

using System;
using Outpost31.Core.Runtime;

namespace Outpost31.Core.Blueprint
{
    public class LogDetail
    {
        /// <summary>The summary of the Tingen Web Service configuration at runtime.</summary>
        /// <return>A summary of the Tingen Web Service configuration at runtime.</return>
        public static string Runtime(TngnWbsvRuntimeSettings tngnWbsvRuntimeSettings)
        {
            return $"========================================{Environment.NewLine}" +
                   $"Tingen Web Service - Runtime Details{Environment.NewLine}" +
                   $"========================================{Environment.NewLine}" +
                   $"Updated {DateTime.Now:MM/dd/yyyy HH:mm:ss}{Environment.NewLine}" +
                   $"------------------------------------{Environment.NewLine}" +
                   $"Version:     {tngnWbsvRuntimeSettings.TngnWbsvVersion}{Environment.NewLine}" +
                   $"Build:       {tngnWbsvRuntimeSettings.TngnWbsvBuild}{Environment.NewLine}" +
                   $"Environment: {tngnWbsvRuntimeSettings.TngnWbsvEnvironment}{Environment.NewLine}" +
                   $"Mode:        {tngnWbsvRuntimeSettings.TngnWbsvMode}{Environment.NewLine}" +
                   $"Data Path:   {tngnWbsvRuntimeSettings.TngnWbsvDataPath}{Environment.NewLine}" +
                   $"Host Name:   {tngnWbsvRuntimeSettings.TngnWbsvHostName}{Environment.NewLine}" +
                   $"{Environment.NewLine}" +
                   "To update this information, launch the \"Web Service Testing\" form.";
        }
    }
}
