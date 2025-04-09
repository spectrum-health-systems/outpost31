//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██

// u250409_code
// u250409_documentation

using System;

using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Runtime
{
    public partial class RuntimeSettings
    {
        public string TngnBuild { get; set; }

        public string SystemCode { get; set; }

        public string TngnDataPath { get; set; }

        public string TngnMode { get; set; }

        public string DateStamp { get; set; }

        public string TimeStamp { get; set; }

        public static RuntimeSettings New()
        {
            //////string sysCode = Avatar.SystemCode.Get(@".\AppData\Runtime\tngn.systemcode");
            //////string tngnDataPath = $@"C:\Tingen_Data\{sysCode}";

            //////string tngnModeFile = $@"{tngnDataPath}\Runtime\tngn.mode";
            //////string tngnMode     = DuFile.ReadAndVerifyLocal(tngnModeFile, cat_ValidTngnModes());

            //////if (sysCode.Contains("The contents of are not valid.")) // test
            //////{
            //////    // Log this.
            //////    SpinDown.ExitImmediately();
            //////}

            return new RuntimeSettings()
            {
                TngnBuild    = "250408",
              //  SystemCode   = sysCode,
               // TngnDataPath = tngnDataPath,
              //  TngnMode     = tngnMode,
                DateStamp    = DateTime.Now.ToString("YYMMDD"),
                TimeStamp    = DateTime.Now.ToString("HHMMSS"),
            };
        }
    }
}