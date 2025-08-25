/* u250625_code
 * u250625_documentation
 */

using System;
using System.IO;
using System.Threading;

namespace Outpost31.Core.Logger
{
    internal class LogEvent
    {
        /// <summary>Primeval logs are used when the advanced logging infrastructure isn't available.</summary>
        /// <remarks>
        ///     <para>
        ///         Primeval logs should removed before deploying to production.<br/>
        ///         <br/>
        ///         Since primeval logs may be written very quickly, there is a 1000ms delay<br/>
        ///         before committing data.This can potentially cause performance issues.<br/>
        ///         <br/>
        ///         Syntax:
        ///         <code>
        ///             LogEvent.Primeval(avtrSys, "Optional message.");
        ///         </code>
        ///     </para>
        /// </remarks>
        /// <param name="avtrSys"><include file='AppData/XmlDoc/Common.xml' path='TngnOpto/Class[@name="Common"]/Primeval/*'/></param>
        /// <param name="logMsg">The log message, which defaults to "Primeval log." if not specified.</param>
        internal static void Primeval(string avtrSys, string logMsg = "Primeval log.")
        {
            const string logType = "Primeval";
            string logName       = $"{DateTime.Now:yyMMdd-HHmmss-fffffff}";
            string logPath       = LogPath.AppLogPath(avtrSys, logName, logType);
            string logContent    = LogContent.Basic(logType, logMsg);

            Thread.Sleep(1000);

            File.WriteAllText(logPath, logContent);
        }
    }
}