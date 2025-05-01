// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                      Core.Request.Prototype.cs

// u250501_code
// u250501_documentation

using Outpost31.Core.Session;

namespace Outpost31.Core.Request
{
    public class Prototype
    {
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
