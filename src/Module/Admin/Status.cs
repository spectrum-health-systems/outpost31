// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                         Module.Admin.Status.cs

// u250430_code
// u250430_documentation

using Outpost31.Core.Session;

namespace Outpost31.Module.Admin
{
    internal class Status
    {
        public static void Current(TngnWbsvSession tngnWbsvSession)
        {
            var path = $@"{tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvDataPath}\RuntimeDetails.txt";

            Core.Runtime.TngnWbsvRuntimeSettings.TngnWbsvRuntimeSettingsSummary(tngnWbsvSession.TngnWbsvRuntimeSettings, path);


        }

    }
}
