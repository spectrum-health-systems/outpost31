/* Outpost31.Module.Admin.Status.cs
* u250625_code
 * u250625_documentation
 */


using Outpost31.Core.Logger;
using Outpost31.Core.Session;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Module.Admin
{
    internal class Status
    {
        public static void Current(WsvcSession tngnWbsvSession)
        {
            LogEvent.Debuggler(tngnWbsvSession.RuntimeConfig.AvtrSys, $"[PARSEING STATUS CURRENT REQUEST] '{tngnWbsvSession.ScriptParam.Original}'");

            var path = $@"{tngnWbsvSession.RuntimeConfig.AvtrSys}\RuntimeDetails.txt";

            /* WTF */
            ///var details = Core.Blueprint.LogHeaderBprt.Runtime(tngnWbsvSession.WsvcRun);

            /* WTF */
            ///DuFile.WriteLocal(path, details, true);
        }
    }
}