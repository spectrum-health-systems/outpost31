//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//
// u250311_code
// u250311_documentation

using System;
using System.Collections.Generic;

namespace Outpost31.Core.Runtime
{
    /// <summary>Runtime catalog.</summary>
    internal static class RuntimeCatalog
    {
        /// <summary>Required directories.</summary>
        /// <returns>A dictionary of required directories.</returns>
        internal static Dictionary<string, string> ReqDirs() => new Dictionary<string, string>();

        /// <summary>Required files.</summary>
        /// <returns>A dictionary of required files.</returns>
        internal static Dictionary<string, string> ReqFiles() => new Dictionary<string, string>
            {
                { "TngnBuild",      @"./AppData/Runtime/tngn.build" },
                { "TngnMode",       @"./AppData/Runtime/tgng.mode" },
                { "TngnSystemCode", @"./AppData/Runtime/tgng.systemcode" }
            };

        /// <summary>Valid system codes</summary>
        /// <returns>A list of valid system codes.</returns>
        internal static List<string> ValidSysCodes() => new List<string>()
            {
                "LIVE",
                "UAT"
            };

        /// <summary>Valid Tingen Web Service modes.</summary>
        /// <returns>A dictionary of valid Tingen Web Service modes.</returns>
        internal static List<string> ValidTngnModes() => new List<string>()
            {
                "ENABLED",
                "DISABLED",
                "PASSTHROUGH"
            };


        /// <summary>The summary of runtime configurations.</summary>
        /// <return>The summary of runtime configurations.</return>
        internal static string ConfigSummary(RuntimeConfiguration runtimeConfig) =>
            $"---------------------------------------{Environment.NewLine}" +
            $"Tingen Web Service runtime configuration{Environment.NewLine}" +
            $"---------------------------------------{Environment.NewLine}" +
            $"    Version: {runtimeConfig.TngnVersion}{Environment.NewLine}" +
            $"      Build: {runtimeConfig.TngnBuild}{Environment.NewLine}" +
            $"System Code: {runtimeConfig.TngnSystemCode}{Environment.NewLine}" +
            $"       Mode: {runtimeConfig.TngnMode}{Environment.NewLine}" +
            $"       Date: {runtimeConfig.DateStamp}{Environment.NewLine}" +
            $"       Time: {runtimeConfig.TimeStamp}";
    }
}
