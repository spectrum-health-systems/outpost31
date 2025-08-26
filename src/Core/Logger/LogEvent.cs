/* u250625_code
 * u250625_documentation
 */

using System;
using System.IO;
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
        /// <param name="logMsg">The message to include in the log. Defaults to "Critical log" if not specified.</param>
        internal static void Critical(string avtrSys, string logName, string logMsg = "Critical log")
        {
            const string logType = "Critical";
            //string logName       = $"{DateTime.Now:yyMMdd-HHmmss-fffffff}";
            string logPath       = LogPath.AppLogPath(avtrSys, logName, logType);
            string logContent    = LogContent.Basic(avtrSys, logType, logMsg);

            File.WriteAllText(logPath, logContent);
        }


        /// <summary>Primeval logs are used when the advanced logging infrastructure isn't available.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogEvent"]/Primeval/*'/>
        /// </remarks>
        /// <param name="avtrSys">The sys</param>
        /// <param name="logMsg">The log message, which defaults to "Primeval log." if not specified.</param>
        internal static void Primeval(string avtrSys, string logMsg = "Primeval log")
        {
            const string logType = "Primeval";
            string logName       = $"{DateTime.Now:yyMMdd-HHmmss-fffffff}";
            string logPath       = LogPath.AppLogPath(avtrSys, logName, logType);
            string logContent    = LogContent.Basic(avtrSys, logType, logMsg);

            Thread.Sleep(1000);

            File.WriteAllText(logPath, logContent);
        }
    }
}