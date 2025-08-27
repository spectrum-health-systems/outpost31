/* u250827_code
 * u250827_documentation
 */

using System.Reflection;
using Outpost31.Core.Logger;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Admin
{
    /// <summary>Provides testing and debugging operations.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Admin.xml' path='Core.Admin/Class[@name="Testing"]/ClassDescription/*'/>
    /// </remarks>
    internal static class Testing
    {
        /// <summary>The executing assembly name.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Common.xml' path='TngnOpto/Class[@name="Common"]/ExeAsmName/*'/>
        /// </remarks>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Runs regression tests.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Core.Admin.xml' path='Core.Admin/Class[@name="Testing"]/Regression/*'/>
        /// </remarks>
        /// <param name="origOptObj"></param>
        /// <param name="origScriptParam"></param>
        /// <param name="tngnWsvcVer"></param>
        /// <param name="avtrSys"></param>
        public static void Regression(OptionObject2015 origOptObj, string origScriptParam, string tngnWsvcVer, string avtrSys)
        {
            GenerateAppLogs(avtrSys, 0);
        }

        /// <summary>Generates various application logs.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Core.Admin.xml' path='Core.Admin/Class[@name="Testing"]/GenerateAppLogs/*'/>
        /// </remarks>
        /// <param name="avtrSys">The identifier for the avatar system or application context in which the logging operations are performed.</param>
        /// <param name="msec"></param>
        internal static void GenerateAppLogs(string avtrSys, int msec)
        {
            //10 file
            LogAppEvent.Primeval(avtrSys, msec);

            LogAppEvent.Critical(avtrSys, ExeAsmName, msec, logName: "Regression test", logBody: "Regression test");
            LogAppEvent.Critical(avtrSys, ExeAsmName, msec, logName: "Regression test", logBody: "");
            LogAppEvent.Critical(avtrSys, ExeAsmName, msec);

            LogAppEvent.Debuggler(avtrSys, ExeAsmName);
            LogAppEvent.Debuggler(avtrSys, ExeAsmName, "Regression test");

            LogAppEvent.Error(avtrSys, ExeAsmName, "Regression test");
            LogAppEvent.Error(avtrSys, ExeAsmName, "Regression test", "000");
            LogAppEvent.Error(avtrSys, ExeAsmName);

            LogAppEvent.Trace(avtrSys, ExeAsmName);
        }
    }
}