/* Outpost31.Module.FormAccess.Deny.cs
 * u250625_code
 * u250625_documentation
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
        public static void SysCodeDoc(TngnWsvcSession tngnWbsvSession)
        {
            if ((tngnWbsvSession.OptObj.Original.SystemCode == "DOC"))
            {
                tngnWbsvSession.OptObj.Finalized =tngnWbsvSession.OptObj.Original.ToReturnOptionObject(1, Core.Blueprint.ErrorContent.ModuleFormAccessDeniedGeneral());
            }
            else
            {
                tngnWbsvSession.OptObj.Finalized =tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, "");
            }
        }

        /// <summary>Deny access to the form if the System Code is "DOC" or starts with "HOC".</summary>
        public static void SysCodeDocHoc(TngnWsvcSession tngnWbsvSession)
        {
            if ((tngnWbsvSession.OptObj.Original.SystemCode == "DOC") || (tngnWbsvSession.OptObj.Original.SystemCode.Contains("HOC")))
            {
                tngnWbsvSession.OptObj.Finalized =tngnWbsvSession.OptObj.Original.ToReturnOptionObject(1, Core.Blueprint.ErrorContent.ModuleFormAccessDeniedGeneral());
            }
            else
            {
                tngnWbsvSession.OptObj.Finalized =tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, "");
            }
        }

        /// <summary>Deny access to the form if the System Code is a member of a list.</summary>
        public static void SysCodeFromList(TngnWsvcSession tngnWbsvSession, List<string> sysCodeList)
        {
            if (sysCodeList.Contains(tngnWbsvSession.OptObj.Original.SystemCode))
            {
                tngnWbsvSession.OptObj.Finalized =tngnWbsvSession.OptObj.Original.ToReturnOptionObject(1, Core.Blueprint.ErrorContent.ModuleFormAccessDeniedGeneral());
            }
            else
            {
                tngnWbsvSession.OptObj.Finalized =tngnWbsvSession.OptObj.Original.ToReturnOptionObject(0, "");
            }
        }
    }
}