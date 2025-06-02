// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                      Core.Template.Messages.cs

// u250602_code
// u250602_documentation

using System.IO;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Blueprint
{
    public class LogMessage
    {
        /* Critical error messages.
         */

        public static string ServiceCriticalFailure()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Templates\Messages\TngnWbsv.CriticalFailure.msg");
        }

        public static string ServiceMissingArguments(OptionObject2015 sentOptObj, string sentScriptParam)
        {
            string optObjStatus = Outpost31.Core.Avatar.OptionObjects.Validate(sentOptObj);
            string scriptParamStatus = (Outpost31.Core.Avatar.ScriptParameter.Validate(sentScriptParam));

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