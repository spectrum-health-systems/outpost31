// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                    Core.Configuration.TngnConfig.Properties.cs

// u250410_code
// u250410_documentation

/* Since there are a bunch of properties in the TngnWbsvConfiguration class, they will be defined in
 * this partial class. This is to keep the code clean and organized.
 */

using Outpost31.Core.Runtime;

namespace Outpost31.Core.Configuration
{
    public partial class TngnWbsvConfiguration
    {
        public TngnWbsvRuntimeSettings tngnWbsvRuntimeSettings { get; set; }

        /// <summary>A summary of the runtime settings for exporting.</summary>
        public string tngnWbsvConfigSummary { get; set; }
    }
}