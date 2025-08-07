/* Outpost31.Module.Prototype.Code.cs
 * u250625_code
 * u250625_documentation
 */

using Outpost31.Core.Session;

namespace Outpost31.Module.Prototype
{
    /// <summary>Prototype code</summary>
    public class Code
    {
        /// <summary>Deny access to the form for anyone using the DOC System Code.</summary>
        /// <remarks>This functionality was added as a standard request on 5-1-2025.</remarks>
        public static void FormAccessDocSysCodeDeny(WsvcSession tngnWbsvSession)
        {
            tngnWbsvSession.OptObj.Original =(tngnWbsvSession.OptObj.Original.SystemCode == "DOC")
                ? tngnWbsvSession.OptObj.Original.ToReturnOptionObject(1, "Access denied")
                : tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, "");
        }
    }
}