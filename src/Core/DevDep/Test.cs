using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.DevDep
{
    internal class Test
    {
        public static void Regress(OptionObject2015 origOptObj, string origScriptParam, string tngnWsvcVer, string avtrSys)
        {
            Logger.LogEvent.Primeval(avtrSys, $"Regression test: Primeval log");
            Logger.LogEvent.Critical(avtrSys, $"Regression testing", "Regression test: Critical log");

        }
    }
}
