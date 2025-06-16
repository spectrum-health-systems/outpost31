/* Outpost31.Module.FormAccess.Deny.cs
 * u250616_code
 * u250616_documentation
 */

using System.Collections.Generic;
using System.IO;
using System.Linq;
using Outpost31.Core.Session;

namespace Outpost31.Module.FormAccess
{
    public class Deny
    {
        /// <summary>Deny access to the form if the System Code is "DOC".</summary>
        public static void SysCodeDoc(TngnWbsvSession tngnWbsvSession)
        {
            if ((tngnWbsvSession.SentOptObj.SystemCode == "DOC"))
            {
                tngnWbsvSession.ReturnOptObj =tngnWbsvSession.SentOptObj.ToReturnOptionObject(1, Core.Blueprint.LogMessage.FormAccessDeniedGeneral());
            }
            else
            {
                tngnWbsvSession.ReturnOptObj =tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, "");
            }
        }

        /// <summary>Deny access to the form if the System Code is "DOC" or starts with "HOC".</summary>
        public static void SysCodeDocHoc(TngnWbsvSession tngnWbsvSession)
        {
            if ((tngnWbsvSession.SentOptObj.SystemCode == "DOC") || (tngnWbsvSession.SentOptObj.SystemCode.Contains("HOC")))
            {
                tngnWbsvSession.ReturnOptObj =tngnWbsvSession.SentOptObj.ToReturnOptionObject(1, Core.Blueprint.LogMessage.FormAccessDeniedGeneral());
            }
            else
            {
                tngnWbsvSession.ReturnOptObj =tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, "");
            }
        }

        /// <summary>Deny access to the form if the System Code is a member of a list.</summary>
        public static void SysCodeFromList(TngnWbsvSession tngnWbsvSession, List<string> sysCodeList)
        {
            if (sysCodeList.Contains(tngnWbsvSession.SentOptObj.SystemCode))
            {
                tngnWbsvSession.ReturnOptObj =tngnWbsvSession.SentOptObj.ToReturnOptionObject(1, Core.Blueprint.LogMessage.FormAccessDeniedGeneral());
            }
            else
            {
                tngnWbsvSession.ReturnOptObj =tngnWbsvSession.SentOptObj.ToReturnOptionObject(0, "");
            }
        }
    }
}