//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██

// u250408_code
// u250408_documentation

using System;
using System.Collections.Generic;

namespace Outpost31.Core.Runtime
{
    public partial class TngnConfiguration
    {

        //internal static Dictionary<string, string> cat_TngnDirectories(string dataPath, string systemCode) => new Dictionary<string, string>
        //{
        //    { "RuntimeData",     @"./AppData/Runtime" },
        //    { "DataPathRoot",   $@"{dataPath}/{systemCode}"},
        //    { "LogPathRoot",    $@"{dataPath}/{systemCode}/Logs" }
        //};

        ///// <summary>Tingen Web Service required directories.</summary>
        ///// <returns>A dictionary of directories required by the Tingen Web Service.</returns>
        ///// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/cat_RequiredDirectories/*'/>
        //internal static Dictionary<string, string> cat_RequiredDirectories(string hostDataPath) => new Dictionary<string, string>
        //{
        //    { "AppData",     @"./AppData" },
        //    { "RuntimeData", @"./AppData/Runtime" },
        //    { "HostDataPath", hostDataPath }
        //};

        ///// <summary>Tingen Web Service required files.</summary>
        ///// <returns>A dictionary of files required by the Tingen Web Service.</returns>
        ///// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/cat_RequiredFiles/*'/>
        //internal static Dictionary<string, string> cat_RequiredFiles(string hostDataPath) => new Dictionary<string, string>
        //    {
        //        { "TngnBuild",        @"./AppData/Runtime/tngn.build" },
        //        { "TngnSystemCode",   @"./AppData/Runtime/tngn.systemcode" },
        //        { "TngnHostDataPath", @"./AppData/Runtime/tngn.hostdatapath" },
        //        { "TngnMode",         $@"{hostDataPath}\tngn.mode"}
        //    };

        ///// <summary>Tingen Web Service required files.</summary>
        ///// <returns>A dictionary of files required by the Tingen Web Service.</returns>
        ///// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/cat_RequiredFiles/*'/>
        //internal static Dictionary<string, string> cat_RequiredTngnDataFiles() => new Dictionary<string, string>
        //    {
        //        { "TngnMode", @"./AppData/Runtime/tgng.mode" }
        //    };


        ///// <summary>Tingen Web Service valid Avatar System Codes.</summary>
        ///// <returns>A list of Avatar System Codes that can be used with the Tingen Web Service.</returns>
        ///// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/cat_ValidSystemCodes/*'/>
        //internal static List<string> cat_ValidSystemCodes() => new List<string>()
        //    {
        //        "LIVE",
        //        "UAT"
        //    };

        ///// <summary>Valid Tingen Web Service modes.</summary>
        ///// <returns>A dictionary of valid Tingen Web Service modes.</returns>
        ///// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/cat_ValidTngnModes/*'/>
        //internal static List<string> cat_ValidTngnModes() => new List<string>()
        //    {
        //        "ENABLED",
        //        "DISABLED",
        //        "PASSTHROUGH"
        //    };

        /// <summary>The summary of the Tingen Web Service configuration at runtime.</summary>
        /// <return>A summary of the Tingen Web Service configuration at runtime.</return>
        internal static string ConfigSummary(TngnConfiguration tngnConfig) =>
            $"----------------------------------------{Environment.NewLine}" +
            $"Tingen Web Service runtime configuration{Environment.NewLine}" +
            $"----------------------------------------{Environment.NewLine}" +
            $"    Version: {tngnConfig.TngnVersion}{Environment.NewLine}" +
            $"      Build: {tngnConfig.TngnBuild}{Environment.NewLine}" +
            $"System Code: {tngnConfig.TngnSystemCode}{Environment.NewLine}" +
            $"       Mode: {tngnConfig.TngnMode}{Environment.NewLine}" +
            $"       Date: {tngnConfig.CurrentDate}{Environment.NewLine}" +
            $"       Time: {tngnConfig.CurrentTime}" +
            $"   Hostname: {tngnConfig.TngnHostName}{Environment.NewLine}";
    }
}