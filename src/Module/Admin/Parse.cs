/* Outpost31.Module.Admin.Parse.cs
 * u250616_code
 * u250616_documentation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outpost31.Core.Logger;
using Outpost31.Core.Session;
using Outpost31.Core.Blueprint;

namespace Outpost31.Module.Admin
{
    public class Parse
    {
        /// <summary>Admin requests.</summary>
        public static void Request(WsvcSession tngnWbsvSession)
        {
            LogEvent.Debuggler(tngnWbsvSession.WsvcRun.TngnWsvcAvtrSys, $"[PARSEING ADMIN REQUEST] '{tngnWbsvSession.ScriptParam.Original}'");

            switch (tngnWbsvSession.ScriptParam.Original.ToLower())
            {
                case "admin.reset.config":
                    LogEvent.Debuggler(tngnWbsvSession.WsvcRun.TngnWsvcAvtrSys, $"[PARSEING RESET CONFIG] '{tngnWbsvSession.ScriptParam.Original}'");
                    Reset.Config(tngnWbsvSession.WsvcRun.TngnWsvcAvtrSys);
                    break;

                case "admin.status.current":
                    LogEvent.Debuggler(tngnWbsvSession.WsvcRun.TngnWsvcAvtrSys, $"[PARSEING STATUS CURRENT] '{tngnWbsvSession.ScriptParam.Original}'");
                    Status.Current(tngnWbsvSession);
                    break;

                default:
                    LogEvent.Debuggler(tngnWbsvSession.WsvcRun.TngnWsvcAvtrSys, $"[PARSEING DEFAULT REQUEST] '{tngnWbsvSession.ScriptParam.Original}'");
                    tngnWbsvSession.OptObj.Finalized = tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, BpWsvc.WsvcInvalidRequest(tngnWbsvSession.ScriptParam.Original));
                    break;
            }

            LogEvent.Debuggler(tngnWbsvSession.WsvcRun.TngnWsvcAvtrSys, $"[PARSEING NOTHING] '{tngnWbsvSession.ScriptParam.Original}'");
        }
    }
}
