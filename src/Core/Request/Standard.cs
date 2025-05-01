// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                       Core.Request.Standard.cs

// u250501_code
// u250501_documentation

using Outpost31.Core.Session;

namespace Outpost31.Core.Request
{
    public class Standard
    {
        public static void Parse(TngnWbsvSession tngnWbsvSession)
        {
            switch (tngnWbsvSession.SentScriptParam.ToLower())
            {
                case "admin.status.current":
                    Module.Admin.Status.Current(tngnWbsvSession);// Handle the standard request
                    break;

                case "formaccess.deny.docsyscode":
                    Module.FormAccess.Deny.DocSysCode(tngnWbsvSession);
                    break;

                default:
                    tngnWbsvSession.ReturnOptObj = tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, "Unknown request.");
                    break;
            }
        }
    }
}
