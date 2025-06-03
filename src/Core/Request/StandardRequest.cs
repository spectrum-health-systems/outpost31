// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                       Core.Request.Standard.cs

// u250508_code
// u250508_documentation

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Outpost31.Core.Session;
using Outpost31.Core.Template;

namespace Outpost31.Core.Request
{
    /// <summary>Handles standard requests.</summary>
    public class StandardRequest
    {
        /// <summary>Parse the request and call the appropriate module.</summary>
        public static void Parse(TngnWbsvSession tngnWbsvSession)
        {
            if (tngnWbsvSession.SentScriptParam.ToLower().StartsWith("admin"))
            {
                Admin(tngnWbsvSession);
            }
            else if (tngnWbsvSession.SentScriptParam.ToLower().StartsWith("formaccess"))
            {
                FormAccess(tngnWbsvSession);
            }
            else
            {
                tngnWbsvSession.ReturnOptObj = tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, Message.ServiceUnknownRequest(tngnWbsvSession.SentScriptParam));
            }
        }

        /// <summary>Admin requests.</summary>
        private static void Admin(TngnWbsvSession tngnWbsvSession)
        {
            switch (tngnWbsvSession.SentScriptParam.ToLower())
            {
                case "admin.status.current":
                    Module.Admin.Status.Current(tngnWbsvSession);// Handle the standard request
                    break;

                default:
                    tngnWbsvSession.ReturnOptObj = tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, Message.ServiceUnknownRequest(tngnWbsvSession.SentScriptParam));
                    break;
            }
        }

        /// <summary>Form access requests.</summary>
        private static void FormAccess(TngnWbsvSession tngnWbsvSession)
        {
            if (tngnWbsvSession.SentScriptParam.ToLower().Contains("list"))
            {
                FormAccessFromList(tngnWbsvSession);
            }
            else
            {
                switch (tngnWbsvSession.SentScriptParam.ToLower())
                {
                    case "formaccess.deny.syscodedoc":
                        Module.FormAccess.Deny.SysCodeDoc(tngnWbsvSession);
                        break;

                    case "formaccess.deny.syscodedochoc":
                        Module.FormAccess.Deny.SysCodeDoc(tngnWbsvSession);
                        break;

                    default:
                        tngnWbsvSession.ReturnOptObj = tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, Message.ServiceUnknownRequest(tngnWbsvSession.SentScriptParam));
                        break;
                }
            }
        }

        /// <summary>Form access from a list.</summary>
        private static void FormAccessFromList(TngnWbsvSession tngnWbsvSession)
        {
            var listNumber = tngnWbsvSession.SentScriptParam.Substring(tngnWbsvSession.SentScriptParam.Length - 2, 2);

            if (File.Exists($@"C:\Tingen_Data\WebService\UAT\Imports\Lists\FormAccess.Deny.{listNumber}.list"))
            {
                List<string> sysCodeList = File.ReadLines($@"C:\Tingen_Data\WebService\UAT\Imports\Lists\FormAccess.Deny.{listNumber}.list").ToList();

                Module.FormAccess.Deny.SysCodeFromList(tngnWbsvSession, sysCodeList);
            }
            else
            {
                tngnWbsvSession.ReturnOptObj = tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, Message.ServiceUnknownRequest(tngnWbsvSession.SentScriptParam));
            }
        }
    }
}