// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                 Module.Prototype.DocSysCode.cs

// u250430_code
// u250430_documentation

using System.IO;
using ScriptLinkStandard.Objects;

namespace Outpost31.Module.Prototype
{
    /// <summary>Prototype code for the DOC System Code.</summary>
    /// <include file='AppData/XmlDoc/Module.Prototype.xml' path='Module.Prototype/Class[@name="DocSysCode"]/ClassDescription/*'/>
    public class DocSysCode
    {
        /// <summary>Deny access to the form for anyone using the DOC System Code.</summary>
        /// <param name="sentOptObj">The OptionObject sent from Avatar.</param>
        /// <param name="sentSlnkScriptParam">The Script Parameter sent from Avatar.</param>
        /// <returns>An OptionObject.</returns>
        /// <include file='AppData/XmlDoc/Module.Prototype.xml' path='Module.Prototype/Class[@name="DocSysCode"]/DenyAccessToForm/*'/>
        public static OptionObject2015 DenyAccessToForm(OptionObject2015 sentOptObj, string sentSlnkScriptParam)
        {
            if (sentOptObj.SystemCode == "DOC")
            {
                return sentOptObj.ToReturnOptionObject(1, MsgAccessDenied());
            }
            else
            {
                return sentOptObj.ToReturnOptionObject(0, "");
            }
        }

        /// <summary>The Access Denied error code message.</summary>
        /// <returns>The Access Denied error code message.</returns>
        private static string MsgAccessDenied()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\ErrorCodeMessages\Module.Prototype.DocSysCode.AccessDenied");
        }
    }
}