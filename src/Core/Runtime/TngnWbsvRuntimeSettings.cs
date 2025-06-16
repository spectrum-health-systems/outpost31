/* Outpost31.Core.Runtime.TngnWbsvRuntimeSettings.cs
 * u250616_code
 * u250616_documentation
 */

using System;
using System.Collections.Generic;
using Outpost31.Core.Logger;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Runtime
{
    /// <summary>Runtime settings for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnWbsvRuntimeSettings"]/ClassDescription/*'/>
    public class TngnWbsvRuntimeSettings
    {
        /// <summary>The Tingen Web Service version number.</summary>
        public string TngnWbsvVersion { get; set; }

        /// <summary>The Tingen Web Service build number.</summary>
        public string TngnWbsvBuild { get; set; }

        /// <summary>The environment that the Tingen Web Service will interface with.</summary>
        public string TngnWbsvEnvironment { get; set; }

        /// <summary>The Tingen Web Service mode.</summary>
        public string TngnWbsvMode { get; set; }

        /// <summary>The Tingen Web Service data path.</summary>
        public string TngnWbsvDataPath { get; set; }

        /// <summary>The name of the machine running the Tingen Web Service.</summary>
        public string TngnWbsvHostName { get; set; }

        /// <summary>The current date in YYMMDD format.</summary>
        public string CurrentDate { get; set; }

        /// <summary>The current time in HHMMSS format.</summary>
        public string CurrentTime { get; set; }

        /// <summary>Creates a new instance of the RuntimeSettings class.</summary>
        /// <returns>An object containing the runtime settings for the Tingen Web Service.</returns>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnWbsvRuntimeSettings"]/New/*'/>
        public static TngnWbsvRuntimeSettings New(string tngnWbsvVersion, string tngnWbsvEnvironment)
        {
            /* #DEVNOTE#
             * Please read the XML Documentation for this method for important information.
             */

            LogEvent.Debuggler(tngnWbsvEnvironment, $"[CREATE DATA PATH]");

            string tngnWbsvDataPath    = $@"C:\Tingen_Data\WebService\{tngnWbsvEnvironment}";

            LogEvent.Debuggler(tngnWbsvEnvironment, $"[GET MODE]");

            string tngnWbsvMode        = GetTngnWbsvMode($@"{tngnWbsvDataPath}\Runtime\TngnWbsv.Mode", ValidTngnWbsvModes());

            LogEvent.Debuggler(tngnWbsvEnvironment, $"[CREATING RUNTIME SETTINGS]");


            var thing = new TngnWbsvRuntimeSettings()
            {
                TngnWbsvVersion     = tngnWbsvVersion,
                TngnWbsvBuild       = "250512",
                TngnWbsvEnvironment = tngnWbsvEnvironment,
                TngnWbsvMode        = tngnWbsvMode,
                TngnWbsvDataPath    = tngnWbsvDataPath,
                TngnWbsvHostName    = Environment.MachineName,
                CurrentDate         = DateTime.Now.ToString("YYMMDD"),
                CurrentTime         = DateTime.Now.ToString("HHMMSS"),
            };

            LogEvent.Debuggler(tngnWbsvEnvironment, $"[RUNTIME SETTINGS CREATED]");

            return thing;

            //return new TngnWbsvRuntimeSettings()
            //{
            //    TngnWbsvVersion     = tngnWbsvVersion,
            //    TngnWbsvBuild       = "250512",
            //    TngnWbsvEnvironment = tngnWbsvEnvironment,
            //    TngnWbsvMode        = tngnWbsvMode,
            //    TngnWbsvDataPath    = tngnWbsvDataPath,
            //    TngnWbsvHostName    = Environment.MachineName,
            //    CurrentDate         = DateTime.Now.ToString("YYMMDD"),
            //    CurrentTime         = DateTime.Now.ToString("HHMMSS"),
            //};
        }

        /// <summary>Get the contents of a file, and validate it.</summary>
        /// <param name="filePath">The file path.</param>
        /// <param name="validateAgainst">A list of values to validate against.</param>
        /// <returns>The valid contents of the file (or we exit the application).</returns>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnWbsvRuntimeSettings"]/TngnWbsvRuntimeSettings.New/*'/>
        private static string GetTngnWbsvMode(string filePath, List<string> validateAgainst)
        {
            /* Trace Logs won't work here. */

            string tngnWbsvMode = DuFile.ReadAndVerifyLocal(filePath, validateAgainst);

            if (tngnWbsvMode.Contains("The contents of are not valid.")) // test
            {
                // Log this.
                Service.Spin.DownImmediately();
            }

            //#DEVNOTE# Test to make sure this works if the contents are not valid.
            return tngnWbsvMode;
        }

        /// <summary>Valid Tingen Web Service modes.</summary>
        /// <returns>A list of valid Tingen Web Service modes.</returns>
        private static List<string> ValidTngnWbsvModes()
        {
            return new List<string>()
            {
                "enabled",
                "disabled",
                "passthrough"
            };
        }
    }
}