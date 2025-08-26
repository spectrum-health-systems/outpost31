/* u250625_code
 * u250625_documentation
 */

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Threading;

namespace Outpost31.Core.Logger
{
    /// <summary>Logs an event.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogEvent"]/ClassDescription/*'/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='TngnOpto/Class[@name="ProjectInfo"]/Callback/*'/>
    /// </remarks>
    internal static class LogEvent
    {
        /// <summary>Logs a critical message to a file with a timestamped name.</summary>
        /// <param name="avtrSys">The name of the system or application generating the log. This value is used to determine the log file path.</param>
        /// <param name="logBody">The message to include in the log. Defaults to "Critical log" if not specified.</param>
        internal static void Critical(string avtrSys, string logName, string logBody = "Critical log")
        {
            const string logType = "Critical";
            //logName += $"-{DateTime.Now:yyMMdd-HHmmss-fffffff}";
            string logPath       = LogPath.AppLogPath(avtrSys, logType, $"{logName}-");
            string logContent    = LogContent.Basic(avtrSys, logType, logBody);

            File.WriteAllText(logPath, logContent);
        }

        internal static void Debuggler(string avtrSys, string logName, string logBody = "Debuggler log")
        {
            const string logType = "Debuggler";
            //logName += $"-{DateTime.Now:yyMMdd-HHmmss-fffffff}";
            string logPath       = LogPath.AppLogPath(avtrSys, logType, $"{logName}-");
            string logContent    = LogContent.Basic(avtrSys, logType, logBody);
            File.WriteAllText(logPath, logContent);
        }

        /// <summary>Primeval logs are used when the advanced logging infrastructure isn't available.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogEvent"]/Primeval/*'/>
        /// </remarks>
        /// <param name="avtrSys">The sys</param>
        /// <param name="logBody">The log message, which defaults to "Primeval log." if not specified.</param>
        internal static void Primeval(string avtrSys, string logBody = "Primeval log")
        {
            const string logType = "Primeval";
            //string logName       = ""; // Primeval logs do not use a log name.
            string logPath       = LogPath.AppLogPath(avtrSys, logType, "");// Primeval logs do not use a log name.
            string logContent    = LogContent.Basic(avtrSys, logType, logBody);

            Thread.Sleep(1000);

            File.WriteAllText(logPath, logContent);
        }

        internal static void Trace(string avtrSys, string logName, string exeAsmName, string logBody = "Trace log", [CallerFilePath] string fromClass = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0)
        {
            const string logType = "Trace";
            //logName += $"-{DateTime.Now:yyMMdd-HHmmss-fffffff}";
            string logPath       = LogPath.AppLogPath(avtrSys, logType, $"{logName}-");
            string logContent    = LogContent.Detailed(avtrSys, logType, logBody, exeAsmName, fromClass, fromMethod, fromLine.ToString());
            File.WriteAllText(logPath, logContent);
        }
    }
}

//TraceLog(string logType, int traceLevel, string avtrEnv, string exeAsm, string fromPath, string fromMethod, int fromLine, string logBody = "")
// string assemblyName, [CallerFilePath] string callPath = "", [CallerMemberName] string callMember = "")