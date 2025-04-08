//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██

// u250408_code
// u250408_documentation

using System;
using System.IO;

namespace Outpost31.Core.Runtime
{
    public class RuntimeSettings
    {
        public string TngnBuild { get; set; }

        public string SystemCode { get; set; }

        public string TngnDataPath { get; set; }

        public string TngnMode { get; set; }
        public string DateStamp { get; set; }
        public string TimeStamp { get; set; }

        public static RuntimeSettings Get()
        {
            string systemCode   = File.ReadAllText(@"./AppData/Runtime/tngn.systemcode");
            string tngnDataPath = $@"C:\Tingen_Data\{systemCode}";

            return new RuntimeSettings()
            {
                TngnBuild    = "250408",
                SystemCode   = File.ReadAllText(@"./AppData/Runtime/tngn.systemcode"),
                TngnDataPath = tngnDataPath,
                TngnMode     = $@"{tngnDataPath}/Runtime/tngn.mode",
                DateStamp    = DateTime.Now.ToString("YYMMDD"),
                TimeStamp    = DateTime.Now.ToString("HHMMSS"),
            };
        }
    }
}