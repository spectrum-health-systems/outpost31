/* u250825_code
 * u250825_documentation
 */

using ScriptLinkStandard.Objects;

namespace Outpost31.Module.DevDep
{
    public class Develop
    {
        public static void Gamut(OptionObject2015 origOptObj, string origScriptParam, string tngnWsvcVer, string avtrSys)
        {
            Core.Logger.LogEvent.Primeval(avtrSys, $"The TingenWebService has started");
            //-//RuntimeConfiguration.VerifyExists(avtrSys);
        }

    }
}