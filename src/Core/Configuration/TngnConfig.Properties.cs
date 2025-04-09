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
    public partial class TngnConfig
    {
        /* Defined at runtime
         */

        /// <summary>Directories required by the Tingen Web Service.</summary>
        /// <remarks>The Tingen Web Service requires these directories to be present.</remarks>
        public Dictionary<string, string> TngnDirectory { get; set; }

        /// <summary>Files required by the Tingen Web Service.</summary>
        /// <remarks>The Tingen Web Service requires these files to be present.</remarks>
        public Dictionary<string, string> TngnFile { get; set; }

        /// <summary>Directories required by the Tingen Web Service.</summary>
        /// <remarks>The Tingen Web Service requires these directories to be present.</remarks>
        public Dictionary<string, string> DataDirectory { get; set; }

        /// <summary>Files required by the Tingen Web Service.</summary>
        /// <remarks>The Tingen Web Service requires these files to be present.</remarks>
        public Dictionary<string, string> DataFile { get; set; }

        /// <summary>The Tingen Web Service version.</summary>
        /// <remarks>Pulled from the Executing Assembly.</remarks>
        public string TngnVersion { get; set; }

        /// <summary>The Tingen Web Service build.</summary>
        /// <remarks>Pulled from AppData\Runtime\tngn.build.</remarks>
        public string TngnBuild { get; set; }

        /// <summary>The Tingen Web Service System Code.</summary>
        /// <remarks>Pulled from AppData\Runtime\tngn.systemcode.</remarks>
        public string TngnSystemCode { get; set; }

        /// <summary>The list of valid System Codes.</summary>
        /// <remarks>The Tingen Web Service will only interface with these System Codes.</remarks>
        public List<string> ValidSystemCodes { get; set; }

        /// <summary>The Tingen Web Service mode.</summary>
        /// <remarks>Pulled from %HostDataPath%\%SystemCode%\Config\Runtime\tngn.mode.</remarks>
        public string TngnMode { get; set; }

        /// <summary>The list of valid Tingen Web Service modes.</summary>
        /// <remarks>These are the only modes that the Tingen Web Service (and Modules) will recognize.</remarks>
        public List<string> ValidTngnModes { get; set; }

        /// <summary>The name of the machine running the Tingen Web Service.</summary>
        /// <remarks>The host (server) name where the Tingen Web Service runs.</remarks>
        public string TngnHostName { get; set; } = Environment.MachineName;

        /// <summary>The Tingen Web Service host data path.</summary>
        /// <remarks>Pulled from AppData\Runtime\tngn.hostdatapath.</remarks>
        public string TngnDataPath { get; set; }

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