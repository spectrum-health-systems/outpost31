/* Outpost31.Core.Request.PrototypeRequest.cs
 * u250625_code
 * u250625_documentation
 */


using Outpost31.Core.Session;

namespace Outpost31.Core.Request
{
    /// <summary>Handles prototype requests.</summary>
    public class PrototypeRequest
    {
        /// <summary>Parse the request and call the appropriate module.</summary>
        public static void Parse(WsvcSession tngnWbsvSession)
        {
            switch (tngnWbsvSession.ScriptParam.Original.ToLower())
            {
                case "_pformaccess.deny.docsyscode":
                    Module.Prototype.Code.FormAccessDocSysCodeDeny(tngnWbsvSession);
                    break;

                default:
                    tngnWbsvSession.OptObj.Finalized = tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, "Unknown request.");
                    break;
            }
        }
    }
}
