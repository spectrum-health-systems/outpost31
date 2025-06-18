/* Outpost31.Module.Admin.Status.cs
 * u250616_code
 * u250616_documentation
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
            LogEvent.Debuggler(tngnWbsvSession.WsvcRun.TngnWsvcAvtrSys, $"[PARSEING STATUS CURRENT REQUEST] '{tngnWbsvSession.ScriptParam.Original}'");

            var path = $@"{tngnWbsvSession.WsvcRun.TngnWsvcDataPath}\RuntimeDetails.txt";

            var details = Core.Blueprint.LogDetail.Runtime(tngnWbsvSession.WsvcRun);

            DuFile.WriteLocal(path, details, true);
        }
    }
}