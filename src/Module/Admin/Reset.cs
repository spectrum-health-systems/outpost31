/* Outpost31.Module.Admin.Reset.cs
 * u250625_code
 * u250625_documentation
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
            Config(tngnWbsvEnvironment);
        }

        public static void Config(string tngnWbsvEnvironment)
        {
            /* WTF */
            ///Core.Configuration.ConfigCore.CreateDefault(tngnWbsvEnvironment);
        }
    }
}
