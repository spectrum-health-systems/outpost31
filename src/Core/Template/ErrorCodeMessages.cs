// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                             Core.Template.ErrorCodeMessages.cs

// u250501_code
// u250501_documentation

using System.IO;

namespace Outpost31.Core.Template
{
    public class ErrorCodeMessages
    {
        public static string TngnWbsvCriticalFailure()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\ErrorCodeMessages\TingenWebService.CriticalFailure");
        }

        /// <summary>The Access Denied error code message.</summary>
        /// <returns>The Access Denied error code message.</returns>
        public static string FormAccessDenied()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\ErrorCodeMessages\Module.Prototype.DocSysCode.AccessDenied");
        }
    }
}