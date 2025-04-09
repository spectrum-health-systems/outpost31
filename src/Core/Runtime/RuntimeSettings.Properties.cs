// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                             Core.RuntimeSettings.Properties.cs

// u250409_code
// u250409_documentation

namespace Outpost31.Core.Runtime
{
    public partial class RuntimeSettings
    {
        public string TngnEnvironment { get; set; }

        public string TngnBuild { get; set; }

        public string TngnDataPath { get; set; }

        public string TngnMode { get; set; }

        public string DateStamp { get; set; }

        public string TimeStamp { get; set; }
    }
}