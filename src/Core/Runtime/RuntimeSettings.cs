// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                        Core.RuntimeSettings.cs

// u250409_code
// u250409_documentation

using System;
using System.Collections.Generic;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Runtime
{
    public partial class RuntimeSettings
    {
        public string TngnWbsvBuild { get; set; }

        public string TngnWbsvEnvironment { get; set; }

        public string TngnWbsvMode { get; set; }

        public string TngnWbsvDataPath { get; set; }

        public string CurrentDate { get; set; }

        public string CurrentTime { get; set; }

        public static RuntimeSettings New()
        {
            string tngnWbsvEnvironment = GetTngnWbsvDetailFromFile(@".\AppData\Runtime\tngn.systemcode", ValidTngnWbsvEnvironments()); // rename
            string tngnWbsvDataPath    = $@"C:\Tingen_Data\{tngnWbsvEnvironment}";
            string tngnWbsvMode        = GetTngnWbsvDetailFromFile(@".\AppData\Runtime\tngn.mode", ValidTngnWbsvModes()); // rename

            return new RuntimeSettings()
            {
                TngnWbsvBuild       = "250408",
                TngnWbsvEnvironment = tngnWbsvEnvironment,
                TngnWbsvMode        = tngnWbsvMode,
                TngnWbsvDataPath    = tngnWbsvDataPath,
                CurrentDate         = DateTime.Now.ToString("YYMMDD"),
                CurrentTime         = DateTime.Now.ToString("HHMMSS"),
            };
        }

        private static string GetTngnWbsvDetailFromFile(string filePath, List<string> validateAgainst)
        {
            /* Trace Logs won't work here. */

            string tngnWbsvDetail = DuFile.ReadAndVerifyLocal(filePath, validateAgainst);

            if (tngnWbsvDetail.Contains("The contents of are not valid.")) // test
            {
                // Log this.
                Service.Spin.DownImmediately();
            }

            //#DEVNOTE# Test to make sure this works if the contents are not valid.
            return tngnWbsvDetail;
        }

        /// <summary>Tingen Web Service valid environments.</summary>
        /// <returns>A list of environments that can be used with the Tingen Web Service.</returns>
        private static List<string> ValidTngnWbsvEnvironments() => new List<string>()
        {
            "LIVE",
            "UAT"
        };

        /// <summary>Valid Tingen Web Service modes.</summary>
        /// <returns>A dictionary of valid Tingen Web Service modes.</returns>
        private static List<string> ValidTngnWbsvModes() => new List<string>()
        {
            "ENABLED",
            "DISABLED",
            "PASSTHROUGH"
        };
    }
}