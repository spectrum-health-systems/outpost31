/* u250827_code
 * u250827_documentation
 */

using System.Reflection;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Admin
{
    /// <summary>Tingen Web Service mode logic.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Admin.xml' path='Core.Admin/Class[@name="AdminMode"]/ClassDescription/*'/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='TngnOpto/Class[@name="ProjectInfo"]/Callback/*'/>
    /// </remarks>
    public static class AdminMode
    {
        /// <summary>The executing assembly name.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Common.xml' path='TngnOpto/Class[@name="Common"]/ExeAsmName/*'/>
        /// </remarks>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Run one of the AdminModes.</summary>
        /// <param name="origOptObj"></param>
        /// <param name="origScriptParam"></param>
        /// <param name="tngnWsvcVer"></param>
        /// <param name="avtrSys"></param>
        /// <param name="adminMode"></param>
        public static void Run(OptionObject2015 origOptObj, string origScriptParam, string tngnWsvcVer, string avtrSys, string adminMode)
        {
            switch (adminMode.ToLower())
            {
                case "initialize":
                    Deployment.InitializeTngnWsvc(avtrSys);
                    break;

                case "refreshappdata":
                    Deployment.RefreshAppData(avtrSys);
                    break;

                case "regressiontest":
                    Testing.Regression(origOptObj, origScriptParam, tngnWsvcVer, avtrSys);
                    break;
            }
        }
    }
}