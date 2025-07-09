/* Outpost31.Core.Avatar.AvtrParameter.cs
 * u250709_code
 * u250709_documentation
 */

using Outpost31.Core.Blueprint;
using Outpost31.Core.Logger;
using Outpost31.Core.Session;

namespace Outpost31.Core.Avatar
{
    /// <summary>Logic for the Avatar script parameter.</summary>
    /// <remarks>TBD</remarks>
    /// <seealso href="https://github.com/spectrum-health-systems/tingen-documentation-project">Tingen Documentation Project</seealso>
    /// <seealso href="https://spectrum-health-systems.github.io/tingen-documentation-project/api">Tingen API Documentation</seealso>
    public class AvtrParameter
    {
        /// <summary>The original script parameter sent from Avatar.</summary>
        public string Original { get; set; }

        /// <summary>Processes a request based on the parameters provided in the specified session.</summary>
        /// <remarks>TBD</remarks>
        /// <param name="wsvcSession">The session object containing the request parameters and runtime settings</param>
        public static void Request(WsvcSession wsvcSession)
        {
            LogEvent.Debuggler(wsvcSession.RuntimeConfig.AvtrSys, $"[PARSE REQUEST A] '{wsvcSession.ScriptParam.Original}'");  /* TESTING */

            if (wsvcSession.ScriptParam.Original.ToLower().StartsWith("_p"))
            {
                LogEvent.Debuggler(wsvcSession.RuntimeConfig.AvtrSys, $"[PARSEING PROTOTYPE REQUEST] '{wsvcSession.ScriptParam.Original}'"); /* TESTING */

                Core.Request.PrototypeRequest.Parse(wsvcSession);
            }
            else
            {
                LogEvent.Debuggler(wsvcSession.RuntimeConfig.AvtrSys, $"[PARSEING STANDARD REQUEST] '{wsvcSession.ScriptParam.Original}'"); /* TESTING */

                if (wsvcSession.ScriptParam.Original.ToLower().StartsWith("admin"))
                {
                    LogEvent.Debuggler(wsvcSession.RuntimeConfig.AvtrSys, $"[PARSEING ADMIN REQUEST] '{wsvcSession.ScriptParam.Original}'"); /* TESTING */

                    Module.Admin.Parse.Request(wsvcSession);
                }
                else if (wsvcSession.ScriptParam.Original.ToLower().StartsWith("formaccess"))
                {
                    LogEvent.Debuggler(wsvcSession.RuntimeConfig.AvtrSys, $"[PARSEING FORM ACCESS REQUEST] '{wsvcSession.ScriptParam.Original}'"); /* TESTING */
                    // TODO FormAccess(tngnWbsvSession);
                }
                else
                {
                    wsvcSession.OptObj.Finalized = wsvcSession.OptObj.Original.ToReturnOptionObject(0, ErrorContent.WsvcInvalidRequest(wsvcSession.ScriptParam.Original));
                }

                ////LogEvent.Debuggler(tngnWbsvSession.TngnWbsvRuntimeSettings.TngnWbsvEnvironment, $"PARSEING STANDARD REQUEST: {tngnWbsvSession.SentScriptParam}");
                //Core.Request.StandardRequest.Parse(tngnWbsvSession);
            }
        }

        /// <summary>Validates whether the provided script parameter is null, empty, or consists only of white-space characters.</summary>
        /// <param name="origParam">The script parameter to validate.</param>
        /// <returns>A message indicating whether the provided script parameter exists or does not exist.</returns>
        public static string CheckExistence(string origParam)
        {
            return string.IsNullOrWhiteSpace(origParam)
                ? $"The sent script parameter ('{origParam}') does not exist."
                : $"The sent script parameter ('{origParam}') does exist.";
        }
    }
}