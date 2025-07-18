﻿/* Core
 * ███ █ █ ███ ███ ███ ███  ███ ███ ██
 * █ █ █ █  █  ███ █ █ ████  █   ██  █
 * ███ ███  █  █   ███  ███  █  ███  █
 *                  Logger.LogEvent.cs

/* u250603_code
 * u250603_documentation
 */

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Outpost31.Core.Logger
{
    /// <summary>Methods for logging various types of events.</summary>
    /// <remarks>
    ///     <note title="About this class">
    ///         The following types of logs are supported:
    ///         <list type="bullet">
    ///             <item><see cref="Critical(string, string)"/></item>
    ///             <item><see cref="Debug(string, string, string, string, int, string)"/></item>
    ///             <item><see cref="Debuggler(string, string)"/></item>
    ///             <item><see cref="Primeval(string, string, string, string, int, string)"/></item>
    ///             <item><see cref="Trace(int, string, string, string, string, int, string)"/></item>
    ///         </list>
    ///     </note>
    /// </remarks>
    /// <seealso href="https://github.com/spectrum-health-systems/Tingen-Documentation">Tingen documentation</seealso>
    public static class LogEvent
    {
        /// <summary>Critical logs indicate a critical failure with the Tingen Web Service.</summary>
        /// <param name="wbsvEnvironment">The Avatar environment that the Tingen Web Service has interfaced with.</param>
        /// <param name="logMessage">The log message, which defaults to "Critical log." if not specified.</param>
        public static void Critical(string avtrEnv, string logMessage = "Critical log.")
        {
            Dictionary < string, string > logComponent = LogBuilder.BasicLog("Critical", avtrEnv, logMessage);
            LogWriter.WriteLogToFile(logComponent);
        }

        /// <summary>Debug logs are used when developing the Tingen Web Service.</summary>
        /// <remarks>
        ///     <para>
        ///         Debug logs should be commented out in production code, or removed<br/>
        ///         if they are not needed.<br/>
        ///     </para>
        ///     <para>
        ///         Syntax:
        ///         <code>
        ///             TODO: Add syntax here.
        ///         </code>
        ///     </para>
        /// </remarks>
        /// <param name="avtrEnv">The Avatar environment that the Tingen Web Service has interfaced with.</param>
        /// <param name="exeAsm">The name of the assembly generating the log entry.</param>
        /// <param name="fromPath">The full path of the file being logged.</param>
        /// <param name="fromMethod">The name of the method being logged.</param>
        /// <param name="fromLine">The line number being logged.</param>
        /// <param name="logMsg">The log message, which defaults to "Debug log." if not specified.</param>
        public static void Debug(string avtrEnv, string exeAsm, [CallerFilePath] string fromPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0, string logMsg = "Debug log.")
        {
            Dictionary<string, string> logComponent = LogBuilder.DetailedLog("Debug", avtrEnv, exeAsm, fromPath, fromMethod, fromLine, logMsg);

            LogWriter.WriteLogToFile(logComponent);
        }

        /// <summary>Debuggler logs are temporary logs used when you want to debug something specific.</summary>
        /// <remarks>
        ///     <para>
        ///         Debug logs should removed before deploying to production.<br/>
        ///         <br/>
        ///         Since debuggler logs may be written very quickly, there is a 1000ms delay<br/>
        ///         before committing to file.
        ///     </para>
        ///     <para>
        ///        Syntax:
        ///         <code>
        ///             LogEvent.Debuggler(wbsvEnvironment, "Your message here.");
        ///         </code>
        ///     </para>
        /// </remarks>
        /// <param name="avtrEnv">The Avatar environment that the Tingen Web Service has interfaced with.</param>
        /// <param name="logMsg">The log message, which defaults to "Debuggler log." if not specified.</param>
        public static void Debuggler(string avtrEnv, string logMsg = "Debuggler log.")
        {
            Thread.Sleep(1000);

            Dictionary<string, string> logComponent = LogBuilder.BasicLog("Debuggler", avtrEnv, logMsg);

            LogWriter.WriteLogToFile(logComponent);
        }

        /// <summary>Primeval logs are used where other logs cannot.</summary>
        /// <remarks>
        ///     <para>
        ///         Primeval logs should removed before deploying to production.<br/>
        ///         <br/>
        ///         Since debuggler logs may be written very quickly, there is a 1000ms delay<br/>
        ///         before committing to file.
        ///     </para>
        ///     <para>
        ///        Syntax:
        ///         <code>
        ///             LogEvent.Debuggler(wbsvEnvironment, "Your message here.");
        ///         </code>
        ///     </para>
        /// </remarks>
        /// <param name="avtrEnv">The Avatar environment that the Tingen Web Service has interfaced with.</param>
        /// <param name="logMsg">The log message, which defaults to "Primeval log." if not specified.</param>
        public static void Primeval(string avtrEnv, string logMsg = "Primeval log.")
        {
            Thread.Sleep(1000);

            Dictionary < string, string > logComponent = LogBuilder.BasicLog("Primeval", avtrEnv, logMsg);

            LogWriter.WriteLogToFile(logComponent);
        }

        /// <summary>Trace Logs are used for debugging and tracking the flow of the application.</summary>
        /// <remarks>
        ///     <para>
        ///         Trace logs work a little differently than other logs. They are assigned a "<c>TraceLevel</c>" between 0 and 9,<br/>
        ///         which is defined in <c>Tingen_Data\WebService\%avtrEnv%\Config\Runtime\TngnWbsv.config</c>:
        ///         <list type="bullet">
        ///             <item>0 - None</item>
        ///             <item>1 - Methods</item>
        ///             <item>2 - Conditional statements</item>
        ///             <item>9 - All</item>
        ///         </list>
        ///     </para>
        ///     <para>
        ///         Each TraceLevel is cumulative, so if you set the level to "5", it will also include all logs<br/>
        ///         from TraceLevels 1-4. Care should be taken to not set the level too high in production, since<br/>
        ///         it can impact performance and generate a large amount of log files.<br/>
        ///         <br/>
        ///         As long as the web service is functioning as expected, the TraceLevel should be set to "0"<br/>
        ///         <br/>
        ///         Since the TraceLevel handles what Trace Logs are written, Trace Log statements should not be<br/>
        ///         commented out of production code.<br/>
        ///     </para>
        ///     <para>
        ///         Syntax:
        ///         <code>
        ///             TODO: Add syntax here.
        ///         </code>
        ///     </para>
        /// </remarks>
        /// <param name="traceLevel">The Trace Log level.</param>
        /// <param name="avtrEnv">The Avatar environment that interfaces with the Tingen Web Service.</param>
        /// <param name="exeAsm">The name of the assembly generating the trace.</param>
        /// <param name="fromPath">The full path of the file being logged.</param>
        /// <param name="fromMethod">The name of the method being logged.</param>
        /// <param name="fromLine">The line number being logged.</param>
        /// <param name="logMsg">The message to include in the trace log. Defaults to "No message." if not specified.</param>
        public static void Trace(int traceLevel, string avtrEnv, string exeAsm, [CallerFilePath] string fromPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0, string logMsg = "Trace log.")
        {
            Dictionary<string, string> logComponent = LogBuilder.TraceLog("Trace", traceLevel, avtrEnv, exeAsm, fromPath, fromMethod, fromLine, logMsg);

            LogWriter.WriteLogToFile(logComponent);
        }
    }
}