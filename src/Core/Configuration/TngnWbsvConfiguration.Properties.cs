// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                    Core.Configuration.TngnConfig.Properties.cs

// u250409_code
// u250409_documentation

using System;
using System.Collections.Generic;

namespace Outpost31.Core.Configuration
{
    public partial class TngnWbsvConfiguration
    {
        /* Defined at runtime
         */

        /// <summary>Directories required by the Tingen Web Service.</summary>
        /// <remarks>The Tingen Web Service requires these directories to be present.</remarks>
        public Dictionary<string, string> TngnWbsvDirectory { get; set; }

        /// <summary>Files required by the Tingen Web Service.</summary>
        /// <remarks>The Tingen Web Service requires these files to be present.</remarks>
        public Dictionary<string, string> TngnWbsvFile { get; set; }

        /// <summary>Directories required by the Tingen Web Service.</summary>
        /// <remarks>The Tingen Web Service requires these directories to be present.</remarks>
        public Dictionary<string, string> TngnWbsvDataDirectory { get; set; }

        /// <summary>Files required by the Tingen Web Service.</summary>
        /// <remarks>The Tingen Web Service requires these files to be present.</remarks>
        public Dictionary<string, string> TngnWbsvDataFile { get; set; }

        /// <summary>The Tingen Web Service version.</summary>
        /// <remarks>Pulled from the Executing Assembly.</remarks>
        public string TngnWbsvVersion { get; set; }

        /// <summary>The Tingen Web Service build.</summary>
        /// <remarks>Pulled from AppData\Runtime\tngn.build.</remarks>
        public string TngnWbsvBuild { get; set; }

        /// <summary>The Tingen Web Service environment.</summary>
        /// <remarks>Pulled from AppData\Runtime\tngn.environment.</remarks>
        public string TngnWbsvEnvironment { get; set; }

        /// <summary>The list of valid System Codes.</summary>
        /// <remarks>The Tingen Web Service will only interface with these System Codes.</remarks>
        public List<string> ValidTngnWbsvEnvironments { get; set; }

        /// <summary>The Tingen Web Service mode.</summary>
        /// <remarks>Pulled from %HostDataPath%\%SystemCode%\Config\Runtime\tngn.mode.</remarks>
        public string TngnWbsvMode { get; set; }

        /// <summary>The list of valid Tingen Web Service modes.</summary>
        /// <remarks>These are the only modes that the Tingen Web Service (and Modules) will recognize.</remarks>
        public List<string> ValidTngnWbsvModes { get; set; }

        /// <summary>The name of the machine running the Tingen Web Service.</summary>
        /// <remarks>The host (server) name where the Tingen Web Service runs.</remarks>
        public string TngnWbsvHostName { get; set; } = Environment.MachineName; // don't define here

        /// <summary>The Tingen Web Service host data path.</summary>
        /// <remarks>Pulled from AppData\Runtime\tngn.hostdatapath.</remarks>
        public string TngnWbsvDataPath { get; set; }

        /// <summary>The current date.</summary>
        /// <remarks>Today!</remarks>
        public string CurrentDate { get; set; }

        /// <summary>The current time.</summary>
        /// <remarks>Now!</remarks>
        public string CurrentTime { get; set; }

        /// <summary>A summary of the runtime settings for exporting.</summary>
        public string ConfigurationSummary { get; set; }
    }
}