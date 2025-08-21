/* Outpost31.Core.Avatar.AvtrParameter.cs
 * u250821_code
 * u250821_documentation
 */

using Outpost31.Core.Blueprint;
using Outpost31.Core.Logger;
using Outpost31.Core.Session;

namespace Outpost31.Core.Avatar
{
    /// <summary>Logic for the Avatar script parameter.</summary>
    /// <remarks>
    ///      The Script Parameter sent from Avatar contains all of the information that the Tingen Web Service needs to do work.<br/>
    ///     <include file='AppData/XMLDoc/AvtrParameter.xml' path='AvtrParameter/Class[@name="Parameter"]/Description/*'/><br/>
    ///     <include file='AppData/XMLDoc/AvtrParameter.xml' path='AvtrParameter/Class[@name="Parameter"]/ListOf/*'/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='ProjectInfo/Class[@name="Project"]/Callback/*'/>
    /// </remarks>
    public class AvtrParameter
    {
        /// <summary>The original <see cref="AvtrParameter">script parameter</see> sent from Avatar.</summary>
        public string Original { get; set; }

        /// <summary>Parse a script parameter passed from Avatar.</summary>
        /// <remarks>
        ///     <include file='AppData/XMLDoc/AvtrParameter.xml' path='AvtrParameter/Class[@name="Parameter"]/ListOf/*'/>
        /// </remarks>
        /// <param name="wsvcSession">The Tingen Web Service <see cref="WsvcSession">session</see> object containing the request parameters and runtime settings</param>
        public static void Request(WsvcSession wsvcSession)
        {
            if (wsvcSession.ScriptParam.Original.ToLower().StartsWith("_p"))
            {
                Core.Request.PrototypeRequest.Parse(wsvcSession);
            }
            else
            {
                if (wsvcSession.ScriptParam.Original.ToLower().StartsWith("admin"))
                {
                    Module.Admin.Parse.Request(wsvcSession);
                }
                else if (wsvcSession.ScriptParam.Original.ToLower().StartsWith("formaccess"))
                {
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

        /// <summary>Validates whether the provided <see cref="AvtrParameter">script parameter</see> is null, empty, or consists only of white-space characters.</summary>
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