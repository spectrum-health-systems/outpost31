/* Outpost31.Core.Request.StandardRequest.cs
 * u250625_code
 * u250625_documentation
 */


using System.Collections.Generic;
using System.IO;
using System.Linq;
using Outpost31.Core.Session;
using Outpost31.Core.Blueprint;

namespace Outpost31.Core.Request
{
    /// <summary>Handles standard requests.</summary>
    public class StandardRequest
    {
        /// <summary>Parse the request and call the appropriate module.</summary>
        public static void Parse(WsvcSession tngnWbsvSession)
        {
            if (tngnWbsvSession.ScriptParam.Original.ToLower().StartsWith("admin"))
            {
                Admin(tngnWbsvSession);
            }
            else if (tngnWbsvSession.ScriptParam.Original.ToLower().StartsWith("formaccess"))
            {
                FormAccess(tngnWbsvSession);
            }
            else
            {
                tngnWbsvSession.OptObj.Finalized = tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, WsvcErrorBprt.WsvcInvalidRequest(tngnWbsvSession.ScriptParam.Original));
            }
        }

        /// <summary>Admin requests.</summary>
        private static void Admin(WsvcSession tngnWbsvSession)
        {
            switch (tngnWbsvSession.ScriptParam.Original.ToLower())
            {
                case "admin.status.current":
                    Module.Admin.Status.Current(tngnWbsvSession);// Handle the standard request
                    break;

                default:
                    tngnWbsvSession.OptObj.Finalized = tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, WsvcErrorBprt.WsvcInvalidRequest(tngnWbsvSession.ScriptParam.Original));
                    break;
            }
        }

        /// <summary>Form access requests.</summary>
        private static void FormAccess(WsvcSession tngnWbsvSession)
        {
            if (tngnWbsvSession.ScriptParam.Original.ToLower().Contains("list"))
            {
                FormAccessFromList(tngnWbsvSession);
            }
            else
            {
                switch (tngnWbsvSession.ScriptParam.Original.ToLower())
                {
                    case "formaccess.deny.syscodedoc":
                        Module.FormAccess.Deny.SysCodeDoc(tngnWbsvSession);
                        break;

                    case "formaccess.deny.syscodedochoc":
                        Module.FormAccess.Deny.SysCodeDoc(tngnWbsvSession);
                        break;

                    default:
                        tngnWbsvSession.OptObj.Finalized = tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, WsvcErrorBprt.WsvcInvalidRequest(tngnWbsvSession.ScriptParam.Original));
                        break;
                }
            }
        }

        /// <summary>Form access from a list.</summary>
        private static void FormAccessFromList(WsvcSession tngnWbsvSession)
        {
            var listNumber = tngnWbsvSession.ScriptParam.Original.Substring(tngnWbsvSession.ScriptParam.Original.Length - 2, 2);

            if (File.Exists($@"C:\Tingen_Data\WebService\UAT\Imports\Lists\FormAccess.Deny.{listNumber}.list"))
            {
                List<string> sysCodeList = File.ReadLines($@"C:\Tingen_Data\WebService\UAT\Imports\Lists\FormAccess.Deny.{listNumber}.list").ToList();

                Module.FormAccess.Deny.SysCodeFromList(tngnWbsvSession, sysCodeList);
            }
            else
            {
                tngnWbsvSession.OptObj.Finalized = tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, WsvcErrorBprt.WsvcInvalidRequest(tngnWbsvSession.ScriptParam.Original));
            }
        }
    }
}