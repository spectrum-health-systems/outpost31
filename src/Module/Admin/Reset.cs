/* Outpost31.Module.Admin.Reset.cs
 * u250616_code
 * u250616_documentation
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outpost31.Core.Logger;
using Outpost31.Core.Session;

namespace Outpost31.Module.Admin
{
    public class Reset
    {
        public static void All(string tngnWbsvEnvironment)
        {
            LogEvent.Debuggler(tngnWbsvEnvironment, $"[PARSEING RESET ALL");

            Config(tngnWbsvEnvironment);
        }

        public static void Config(string tngnWbsvEnvironment)
        {
            LogEvent.Debuggler(tngnWbsvEnvironment, $"[PARSEING RESET CONFIG B]");

            Core.Configuration.TngnWbsvConfiguration.CreateDefault(tngnWbsvEnvironment);
        }
    }
}
