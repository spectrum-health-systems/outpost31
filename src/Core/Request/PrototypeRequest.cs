// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                      Core.Request.Prototype.cs

// u250508_code
// u250508_documentation

using Outpost31.Core.Session;

namespace Outpost31.Core.Request
{
    /// <summary>Handles prototype requests.</summary>
    public class PrototypeRequest
    {
        /// <summary>Parse the request and call the appropriate module.</summary>
        public static void Parse(TngnWbsvSession tngnWbsvSession)
        {
            switch (tngnWbsvSession.SentScriptParam.ToLower())
            {
                case "_pformaccess.deny.docsyscode":
                    Module.Prototype.Code.FormAccessDocSysCodeDeny(tngnWbsvSession);
                    break;

                default:
                    tngnWbsvSession.ReturnOptObj = tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, "Unknown request.");
                    break;
            }
        }
    }
}
