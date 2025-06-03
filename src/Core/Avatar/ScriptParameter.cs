// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                 Core.Avatar.ScriptParameter.cs

// u250501_code
// u250501_documentation

using Outpost31.Core.Logger;
using Outpost31.Core.Session;
using Outpost31.Core.Template;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Avatar
{
    public class ScriptParameter
    {
        /// <summary>
        /// Processes a request based on the parameters provided in the specified session.
        /// </summary>
        /// <remarks>The method determines the type of request by analyzing the <see
        /// cref="TngnWbsvSession.SentScriptParam"/> property  and delegates the processing to the appropriate handler.
        /// Supported request types include prototype requests,  admin requests, and form access requests. If the
        /// request type is unrecognized, a default response is returned.</remarks>
        /// <param name="tngnWbsvSession">The session object containing the request parameters and runtime settings.  This parameter cannot be
        /// <c>null</c>.</param>
        public static void Request(TngnWbsvSession tngnWbsvSession)
        {
            LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"[PARSE REQUEST A] '{tngnWbsvSession.SentScriptParam}'");

            if (tngnWbsvSession.SentScriptParam.ToLower().StartsWith("_p"))
            {
                LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"[PARSEING PROTOTYPE REQUEST] '{tngnWbsvSession.SentScriptParam}'");
                Core.Request.PrototypeRequest.Parse(tngnWbsvSession);
            }
            else
            {
                LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"[PARSEING STANDARD REQUEST] '{tngnWbsvSession.SentScriptParam}'");

                if (tngnWbsvSession.SentScriptParam.ToLower().StartsWith("admin"))
                {
                    LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"[PARSEING ADMIN REQUEST] '{tngnWbsvSession.SentScriptParam}'");
                    Module.Admin.Parse.Request(tngnWbsvSession);
                }
                else if (tngnWbsvSession.SentScriptParam.ToLower().StartsWith("formaccess"))
                {
                    LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"[PARSEING FORM ACCESS REQUEST] '{tngnWbsvSession.SentScriptParam}'");
                    // TODO FormAccess(tngnWbsvSession);
                }
                else
                {
                    tngnWbsvSession.ReturnOptObj = tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, Message.ServiceUnknownRequest(tngnWbsvSession.SentScriptParam));
                }

                ////LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"PARSEING STANDARD REQUEST: {tngnWbsvSession.SentScriptParam}");
                //Core.Request.StandardRequest.Parse(tngnWbsvSession);
            }
        }

        public static string Validate(string sentScriptParam)
        {
            return (string.IsNullOrWhiteSpace(sentScriptParam))
                ? $"The sent Script Parameter ('{sentScriptParam}') does not exist."
                : $"The sent Script Parameter ('{sentScriptParam}') does exist.";
        }
    }
}