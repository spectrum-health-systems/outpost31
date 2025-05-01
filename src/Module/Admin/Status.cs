// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                         Module.Admin.Status.cs

// u250501_code
// u250501_documentation

using Outpost31.Core.Session;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Module.Admin
{
    internal class Status
    {
        public static void Current(TngnWbsvSession tngnWbsvSession)
        {
            var path = $@"{tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvDataPath}\RuntimeDetails.txt";

            var details = Core.Template.Details.Runtime(tngnWbsvSession.TngnWbsvRuntimeSettings);

            DuFile.WriteLocal(path, details, true);
        }
    }
}