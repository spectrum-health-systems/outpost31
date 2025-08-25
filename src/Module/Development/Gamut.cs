/* u250825_code
 * u250825_documentation
 */

namespace Outpost31.Module.Development
{
    public class Gamut
    {
        public static void FromStart(string tngnWsvcVer, string avtrSys)
        {
            Core.Logger.LogEvent.Primeval(avtrSys, $"The TingenWebService has started");
            //-//RuntimeConfiguration.VerifyExists(avtrSys);
        }

    }
}
