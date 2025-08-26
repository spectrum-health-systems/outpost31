using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.DevDep
{
    internal class Test
    {
        /// <summary>The executing assembly name.</summary>
        /// <remarks>
        ///     <include file='/AppData/XmlDoc/Common.xml' path='TngnOpto/Class[@name="Common"]/ExeAsmName/*'/>
        /// </remarks>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        public static void Regress(OptionObject2015 origOptObj, string origScriptParam, string tngnWsvcVer, string avtrSys)
        {
            GenerateLogs(origOptObj, origScriptParam, tngnWsvcVer, avtrSys);
        }

        internal static void GenerateLogs(OptionObject2015 origOptObj, string origScriptParam, string tngnWsvcVer, string avtrSys)
        {
            Logger.LogEvent.Primeval(avtrSys, $"Regression test: Primeval log");
            Thread.Sleep(1000);
            Logger.LogEvent.Critical(avtrSys, $"Regression testing", "Regression test: Critical log");
            Thread.Sleep(1000);
            Logger.LogEvent.Debuggler(avtrSys, $"Regression testing", "Regression test: Debuggler log");
            Thread.Sleep(1000);
            Logger.LogEvent.Trace(avtrSys, $"Regression testing", ExeAsmName);
            Thread.Sleep(1000);
            Logger.LogEvent.Trace(avtrSys, $"Regression testing", ExeAsmName, "Custom message");
        }
    }
}