/* Outpost31.Module.Admin.Parse.cs
 * u250625_code
 * u250625_documentation
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
            LogEvent.Debuggler(tngnWbsvSession.RuntimeConfig.AvtrSys, $"[PARSEING ADMIN REQUEST] '{tngnWbsvSession.ScriptParam.Original}'");

            switch (tngnWbsvSession.ScriptParam.Original.ToLower())
            {
                case "admin.reset.config":
                    LogEvent.Debuggler(tngnWbsvSession.RuntimeConfig.AvtrSys, $"[PARSEING RESET CONFIG] '{tngnWbsvSession.ScriptParam.Original}'");
                    Reset.Config(tngnWbsvSession.RuntimeConfig.AvtrSys);
                    break;

                case "admin.status.current":
                    LogEvent.Debuggler(tngnWbsvSession.RuntimeConfig.AvtrSys, $"[PARSEING STATUS CURRENT] '{tngnWbsvSession.ScriptParam.Original}'");
                    Status.Current(tngnWbsvSession);
                    break;

                default:
                    LogEvent.Debuggler(tngnWbsvSession.RuntimeConfig.AvtrSys, $"[PARSEING DEFAULT REQUEST] '{tngnWbsvSession.ScriptParam.Original}'");
                    tngnWbsvSession.OptObj.Finalized = tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, ErrorContent.WsvcInvalidRequest(tngnWbsvSession.ScriptParam.Original));
                    break;
            }

            LogEvent.Debuggler(tngnWbsvSession.RuntimeConfig.AvtrSys, $"[PARSEING NOTHING] '{tngnWbsvSession.ScriptParam.Original}'");
        }
    }
}
