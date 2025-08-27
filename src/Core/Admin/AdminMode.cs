/* u250826_code
 * u250826_documentation
 */

using System.Reflection;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Admin
{
    /// <summary>Tingen Web Service mode logic.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.TngnWsvc.xml' path='TngnOpto/Class[@name="TngnWsvcMode"]/ClassDescription/*'/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='TngnOpto/Class[@name="ProjectInfo"]/Callback/*'/>
    /// </remarks>
    public static class AdminMode
    {
        /// <summary>The executing assembly name.</summary>
        /// <remarks>
        ///     <include file='/AppData/XmlDoc/Common.xml' path='TngnOpto/Class[@name="Common"]/ExeAsmName/*'/>
        /// </remarks>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        public static void Run(OptionObject2015 origOptObj, string origScriptParam, string tngnWsvcVer, string avtrSys, string adminMode)
        {
            switch (adminMode.ToLower())
            {
                case "initialize":
                    Deploy.InitializeTngnWsvc(avtrSys);
                    break;

                case "refreshappdata":
                    Deploy.RefreshAppData(avtrSys);
                    break;

                case "testregress":
                    Test.Regress(origOptObj, origScriptParam, tngnWsvcVer, avtrSys);
                    break;
            }
        }
    }
}