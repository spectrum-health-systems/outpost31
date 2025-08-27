/* u250826_code
 * u250826_documentation
 */

using System.Reflection;
using Outpost31.Core.Logger;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Admin
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
            /* For debugging only
             */
            //LogEvent.Trace(avtrSys, ExeAsmName, $"");

            GenerateLogs(origOptObj, origScriptParam, tngnWsvcVer, avtrSys);
        }

        internal static void GenerateLogs(OptionObject2015 origOptObj, string origScriptParam, string tngnWsvcVer, string avtrSys)
        {
            //10 file
            LogEvent.Primeval(avtrSys);

            LogEvent.Critical(avtrSys, ExeAsmName, "Regression test", "Regression test");
            LogEvent.Critical(avtrSys, ExeAsmName, "Regression test", "");
            LogEvent.Critical(avtrSys, ExeAsmName);

            LogEvent.Debuggler(avtrSys, ExeAsmName);
            LogEvent.Debuggler(avtrSys, ExeAsmName, "Regression test");

            LogEvent.Error(avtrSys, ExeAsmName, "Regression test");
            LogEvent.Error(avtrSys, ExeAsmName, "Regression test", "000");
            LogEvent.Error(avtrSys, ExeAsmName);

            LogEvent.Trace(avtrSys, ExeAsmName);
        }
    }
}