/* u250825_code
 * u250825_documentation
 */

using Outpost31.Core.DevDep;
using Outpost31.Module.DevDep;
using ScriptLinkStandard.Objects;

namespace Outpost31.TngnWsvc
{
    public class TngnWsvcMode
    {
        public static string SetMode(OptionObject2015 origOptObj, string origScriptParam, string TngnWsvcVer, string avtrSys, string modeFromSettings)
        {
            switch (modeFromSettings)
            {
                case "RefreshBlueprint":
                    Deploy.RefreshBlueprints(avtrSys);
                    break;

                case "DevGamut":
                    Develop.Gamut(origOptObj, origScriptParam, TngnWsvcVer, avtrSys);
                    break;
            }

            return modeFromSettings.ToLower();
        }
    }
}