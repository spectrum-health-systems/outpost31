using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outpost31.Core.Logger;
using Outpost31.Core.Runtime;

namespace Outpost31.Module.Development
{
    public class Gamut
    {

        /// <summary>Development only.</summary>
        public static void FromTngnWsvc(string tngnWsvcVer, string avtrSys)
        {
            LogEvent.Primeval(avtrSys, $"The TingenWebService has started");
            RuntimeConfiguration.VerifyExists(avtrSys);
        }
    }
}
