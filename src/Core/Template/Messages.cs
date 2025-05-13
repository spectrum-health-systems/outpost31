// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                      Core.Template.Messages.cs

// u250512_code
// u250512_documentation

using System.IO;

namespace Outpost31.Core.Template
{
    public class Messages
    {
        public static string TngnWbsvCriticalFailure()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Templates\Messages\TngnWbsv.CriticalFailure.msg");
        }

        public static string TngnWbsvCriticalFailureDetail(string optObjStatus, string scriptParamStatus)
        {
            var basemsg = File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Templates\Messages\TngnWbsv.CriticalFailure.Detail.msg");

            return basemsg.Replace("{OptObjStatus}", optObjStatus)
                          .Replace("{ScriptParamStatus}", scriptParamStatus);
        }



        public static string TngnWbsvUnknownRequest(string request)
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