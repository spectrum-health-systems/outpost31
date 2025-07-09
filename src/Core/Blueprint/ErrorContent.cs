/* Outpost31.Core.Blueprint.ErrorContent.cs
 * u250709_code
 * u250709_documentation
 */

using System.IO;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Blueprint
{
    /// <summary>Blueprints for Tingen Web Service error messages.</summary>
    public class ErrorContent
    {
        public static string WsvcCriticalUnknown()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Tinplate\WebService\webservice-error-critical-unknown.tinplate");
        }

        public static string WsvcCriticalMissingArgs(OptionObject2015 sentOptObj, string sentScriptParam)
        {
            var tinplate = File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Tinplate\WebService\webservice-error-critical-missing-arguments.tinplate");

            return tinplate.Replace("~OptObjStatus~", Avatar.AvtrOptionObject.CheckExistance(sentOptObj))
                           .Replace("~ScriptParamStatus~", Avatar.AvtrParameter.CheckExistence(sentScriptParam));
        }

        public static string WsvcInvalidRequest(string request)
        {
            var tinplate = File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Tinplate\WebService\webservice-error-invalid-request.tinplate");

            return tinplate.Replace("{Request}", request);
        }

        /// <summary>The Access Denied error code message.</summary>
        /// <returns>The Access Denied error code message.</returns>
        public static string ModuleFormAccessDeniedGeneral()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Templates\Messages\FormAccess.Denied.General.msg");
        }
    }
}