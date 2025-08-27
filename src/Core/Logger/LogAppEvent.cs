/* u250627_code
 * u250627_documentation
 */

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Outpost31.Core.Logger
{
    /// <summary>Logs an event.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogEvent"]/ClassDescription/*'/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='TngnOpto/Class[@name="ProjectInfo"]/Callback/*'/>
    /// </remarks>
    internal static class LogAppEvent
    {
        /// <summary>The executing assembly name.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Common.xml' path='TngnOpto/Class[@name="Common"]/ExeAsmName/*'/>
        /// </remarks>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Generate a critical log.</summary>
        /// <remarks>
        ///
        /// </remarks>
        /// <param name="avtrSys"></param>
        /// <param name="exeAsmName"></param>
        /// <param name="msec"></param>
        /// <param name="logName"></param>
        /// <param name="logBody"></param>
        /// <param name="fromClassPath"></param>
        /// <param name="fromMethod"></param>
        /// <param name="fromLine"></param>
        internal static void Critical(string avtrSys, string exeAsmName, int msec = 0, string logName = "Unknown critical issue", string logBody = "Unknown critical issue.", [CallerFilePath] string fromClassPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0)
        {
            Thread.Sleep(msec);

            var fromClass = GetClassName(fromClassPath);

            var proxyText = File.ReadAllText($@"C:\Tingen_Data\WebService\{avtrSys}\AppData\Blueprint\Log\log.critical");

            var logContent = proxyText.Replace("~CURRENT~DATE~TIME~", DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss"))
                                      .Replace("~LOG~BODY~", logBody)
                                      .Replace("~ASSEMBLY~", exeAsmName)
                                      .Replace("~CLASS~", fromClass)
                                      .Replace("~METHOD~", fromMethod)
                                      .Replace("~LINE~", fromLine.ToString());

            string logPath = $@"C:\Tingen_Data\WebService\{avtrSys}\AppData\Log\{logName}-{DateTime.Now:ddHHmmss}.critical";

            File.WriteAllText(logPath, logContent);
        }

        internal static void Debuggler(string avtrSys, string exeAsmName, string logBody = "Standard debuggler log.", [CallerFilePath] string fromClassPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0, int msec = 0)
        {
            Thread.Sleep(msec);

            var fromClass = GetClassName(fromClassPath);

            var proxyText = File.ReadAllText($@"C:\Tingen_Data\WebService\{avtrSys}\AppData\Blueprint\Log\log.debuggler");

            var logContent = proxyText.Replace("~CURRENT~DATE~TIME~", DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss"))
                                      .Replace("~LOG~BODY~", logBody)
                                      .Replace("~ASSEMBLY~", exeAsmName)
                                      .Replace("~CLASS~", fromClass)
                                      .Replace("~METHOD~", fromMethod)
                                      .Replace("~LINE~", fromLine.ToString());

            string logName = $"{exeAsmName}-{fromClass}-{fromMethod}-{fromLine}-{DateTime.Now:ddHHmmss}";

            string logPath = $@"C:\Tingen_Data\WebService\{avtrSys}\AppData\Log\{logName}.debuggler";

            File.WriteAllText(logPath, logContent);
        }

        internal static void Error(string avtrSys, string exeAsmName, string errorMsg = "Standard error log.", string errorCode = "---", [CallerFilePath] string fromClassPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0, int msec = 0)
        {
            Thread.Sleep(msec);

            var fromClass = GetClassName(fromClassPath);

            var proxyText = File.ReadAllText($@"C:\Tingen_Data\WebService\{avtrSys}\AppData\Blueprint\Log\log.error");

            var logContent = proxyText.Replace("~CURRENT~DATE~TIME~", DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss"))
                                      .Replace("~ERROR~CODE~", errorCode)
                                      .Replace("~ERROR~MESSAGE~", errorMsg)
                                      .Replace("~ASSEMBLY~", exeAsmName)
                                      .Replace("~CLASS~", fromClass)
                                      .Replace("~METHOD~", fromMethod)
                                      .Replace("~LINE~", fromLine.ToString());

            var logName = $"{exeAsmName}-{fromClass}-{fromMethod}-{fromLine}-{DateTime.Now:ddHHmmss}";

            string logPath = $@"C:\Tingen_Data\WebService\{avtrSys}\AppData\Log\{logName}.error";

            File.WriteAllText(logPath, logContent);
        }

        /// <summary>Primeval logs are used when the advanced logging infrastructure isn't available.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogEvent"]/Primeval/*'/>
        /// </remarks>
        /// <param name="avtrSys">The sys</param>
        /// <param name="logBody">The log message, which defaults to "Primeval log." if not specified.</param>
        internal static void Primeval(string avtrSys, int msec = 0)
        {
            Thread.Sleep(msec);

            string logPath = $@"C:\Tingen_Data\WebService\{avtrSys}\AppData\Log\{DateTime.Now:ddHHmmss}.primeval";

            File.WriteAllText(logPath, "");
        }

        internal static void Trace(string avtrSys, string exeAsmName, [CallerFilePath] string fromClassPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0, int msec = 0)
        {
            Thread.Sleep(2000);

            var fromClass = GetClassName(fromClassPath);

            var logName    = $"{exeAsmName}-{fromClass}-{fromMethod}-{fromLine}-{DateTime.Now:ddHHmmss}";
            var logPath    = $@"C:\Tingen_Data\WebService\{avtrSys}\AppData\Log\{logName}.trace";

            File.WriteAllText(logPath, "");
        }

        internal static string GetClassName(string fromClassPath)
        {
            var segments = fromClassPath.Split(new char[] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries);
            var className = segments.Last();
            return className.Replace(".cs", "");
        }
    }
}