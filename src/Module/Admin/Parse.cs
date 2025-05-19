using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outpost31.Core.Logger;
using Outpost31.Core.Session;
using Outpost31.Core.Template;

namespace Outpost31.Module.Admin
{
    public class Parse
    {
        /// <summary>Admin requests.</summary>
        public static void Request(TngnWbsvSession tngnWbsvSession)
        {
            LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"[PARSEING ADMIN REQUEST] '{tngnWbsvSession.SentScriptParam}'");

            switch (tngnWbsvSession.SentScriptParam.ToLower())
            {
                case "admin.reset.config":
                    LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"[PARSEING RESET CONFIG] '{tngnWbsvSession.SentScriptParam}'");
                    Reset.Config(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment);
                    break;

                case "admin.status.current":
                    LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"[PARSEING STATUS CURRENT] '{tngnWbsvSession.SentScriptParam}'");
                    Status.Current(tngnWbsvSession);
                    break;

                default:
                    LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"[PARSEING DEFAULT REQUEST] '{tngnWbsvSession.SentScriptParam}'");
                    tngnWbsvSession.ReturnOptObj = tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, Message.ServiceUnknownRequest(tngnWbsvSession.SentScriptParam));
                    break;
            }

            LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"[PARSEING NOTHING] '{tngnWbsvSession.SentScriptParam}'");
        }
    }
}
