/* u250826_code
 * u250826_documentation
 */

using Outpost31.Core.DevDep;
using Outpost31.Module.DevDep;
using ScriptLinkStandard.Objects;

namespace Outpost31.TngnWsvc
{
    /// <summary>Tingen Web Service mode logic.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.TngnWsvc.xml' path='TngnOpto/Class[@name="TngnWsvcMode"]/ClassDescription/*'/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='TngnOpto/Class[@name="ProjectInfo"]/Callback/*'/>
    /// </remarks>
    public static class TngnWsvcMode
    {
        /// <summary>Sets the Tingen Web Service mode, and potentially does some deployment/development actions.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Core.TngnWsvc.xml' path='TngnOpto/Class[@name="TngnWsvcMode"]/SetMode/*'/>
        /// </remarks>
        public static string SetMode(OptionObject2015 origOptObj, string origScriptParam, string TngnWsvcVer, string avtrSys, string modeFromSettings)
        {
            switch (modeFromSettings.ToLower())
            {
                case "refreshblueprint":
                    Deploy.RefreshBlueprints(avtrSys);
                    break;

                case "regress":
                    Test.Regress(origOptObj, origScriptParam, TngnWsvcVer, avtrSys);
                    break;
            }

            return modeFromSettings.ToLower();
        }
    }
}