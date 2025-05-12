// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                             Core.Template.ErrorCodeMessages.cs

// u250508_code
// u250508_documentation

using System.IO;

namespace Outpost31.Core.Template
{
    public class ErrorCodeMessages
    {
        public static string TngnWbsvCriticalFailure()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\ErrorCodeMessages\TngnWbsv.CriticalFailure.msg");
        }

        public static string TngnWbsvUnknownRequest(string request)
        {
            var baseMsg = File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\ErrorCodeMessages\TngnWbsv.UnknownRequest.msg");

            return baseMsg.Replace("{Request}", request);
        }

        /// <summary>The Access Denied error code message.</summary>
        /// <returns>The Access Denied error code message.</returns>
        public static string FormAccessDeniedGeneral()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\ErrorCodeMessages\FormAccess.Denied.General.msg");
        }
    }
}