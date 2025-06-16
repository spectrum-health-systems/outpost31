/* Outpost31.Module.Prototype.Code.cs
 * u250616_code
 * u250616_documentation
 */

using Outpost31.Core.Session;

namespace Outpost31.Module.Prototype
{
    /// <summary>Prototype code</summary>
    public class Code
    {
        /// <summary>Deny access to the form for anyone using the DOC System Code.</summary>
        /// <remarks>This functionality was added as a standard request on 5-1-2025.</remarks>
        public static void FormAccessDocSysCodeDeny(TngnWbsvSession tngnWbsvSession)
        {
            tngnWbsvSession.ReturnOptObj =(tngnWbsvSession.SentOptObj.SystemCode == "DOC")
                ? tngnWbsvSession.ReturnOptObj.ToReturnOptionObject(1, "Access denied")
                : tngnWbsvSession.ReturnOptObj.ToReturnOptionObject(0, "");
        }
    }
}