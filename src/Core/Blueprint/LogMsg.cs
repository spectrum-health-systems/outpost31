/* Outpost31.Core.Blueprint.LogMsg.cs
 * u250618_code
 * u250618_documentation
 */

using System.IO;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Blueprint
{
    public class LogMsg
    {
        /* ========================
         * Critical error messages.
         * ========================
         */

        public static string WsvcCritFail()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Templates\Messages\WsvcCritFail.txt");
        }

        public static string WsvcMissingArgs(OptionObject2015 sentOptObj, string sentScriptParam)
        {
            string optObjStatus = Outpost31.Core.Avatar.OptionObject.CheckExistance(sentOptObj);
            string scriptParamStatus = (Outpost31.Core.Avatar.ScriptParameter.CheckExistance(sentScriptParam));

            var basemsg = File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Templates\Messages\TngnWbsv.CriticalFailure.Detail.msg");

            return basemsg.Replace("~OptObjStatus~", optObjStatus)
                          .Replace("~ScriptParamStatus~", scriptParamStatus);
        }

        public static string ServiceUnknownRequest(string request)
        {
            var baseMsg = File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Templates\Messages\TngnWbsv.UnknownRequest.msg");

            return baseMsg.Replace("{Request}", request);
        }

        /// <summary>The Access Denied error code message.</summary>
        /// <returns>The Access Denied error code message.</returns>
        public static string FormAccessDeniedGeneral()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Templates\Messages\FormAccess.Denied.General.msg");
        }
    }
}