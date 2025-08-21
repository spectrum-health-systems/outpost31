/* Outpost31.Core.Logger.LogBuilder.cs
 * u250625_code
 * u250625_documentation
 */


using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Outpost31.Core.Logger
{
    /// <summary>Generates various log components.</summary>
    /// <remarks>
    ///     <note title="About this class">
    ///         There are three types of logs enerated by this class:
    ///         <list type="bullet">
    ///             <item><see cref="BasicLog(string, string, string)"/></item>
    ///             <item><see cref="DetailedLog(string, string, string, string, string, int, string)"/></item>
    ///             <item><see cref="TraceLog(string, int, string, string, string, string, int, string)"/></item>
    ///         </list>
    ///     </note>
    /// </remarks>
    /// <seealso href="https://github.com/spectrum-health-systems/Tingen-Documentation">Tingen documentation</seealso>
    public class LogBuilder
    {
        /// <summary>Generates a basic log.</summary>
        /// <remarks>
        ///     <para>
        ///         This method creates the following types of logs:
        ///         <list type="bullet">
        ///             <item><see cref="LogEvent.Critical(string, string)"/></item>
        ///             <item><see cref="LogEvent.Debuggler(string, string)"/></item>
        ///             <item><see cref="LogEvent.Primeval(string, string)"/></item>
        ///         </list>
        ///     </para>
        /// </remarks>
        /// <param name="logType">The type of log to generate.</param>
        /// <param name="avtrEnv">The Avatar environment that the Tingen Web Service has interfaced with.</param>
        /// <param name="logMsg">The log message, which defaults to an empty string if not provided.</param>
        /// <returns>A dictionary containing the log path and content.</returns>
        public static Dictionary<string,string> BasicLog(string logType, string avtrEnv, string logMsg = "")
        {
            string path    = FullPath(avtrEnv, logType);
            string content = BasicContent(logType, logMsg);

            return new Dictionary<string, string>
            {
                {"Path",    path},
                {"Content", content}
            };
        }

        /// <summary>Generates a detailed log.</summary>
        /// <remarks>
        ///     <para>
        ///         This method creates the following types of logs:
        ///         <list type="bullet">
        ///             <item><see cref="LogEvent.Debug(string, string, string, string, int, string)"/></item>
        ///         </list>
        ///     </para>
        /// </remarks>
        /// <param name="logType">The type of log to generate.</param>
        /// <param name="avtrEnv">The Avatar environment that the Tingen Web Service has interfaced with.</param>
        /// <param name="exeAsm">The name of the assembly generating the log entry.</param>
        /// <param name="fromPath">The full path of the file being logged.</param>
        /// <param name="fromMethod">The name of the method being logged.</param>
        /// <param name="fromLine">The line number being logged.</param>
        /// <param name="logMsg">The log message, which defaults to an empty string if not provided.</param>
        /// <returns>A dictionary containing the log path and content.</returns>
        public static Dictionary<string, string> DetailedLog(string logType, string avtrEnv, string exeAsm, string fromPath, string fromMethod, int fromLine, string logMsg = "")
        {
            string path    = FullPath(avtrEnv, logType);
            string content = DetailedContent(logType, avtrEnv, exeAsm, fromPath, fromMethod, fromLine, logMsg);

            return new Dictionary<string, string>
            {
                {"Path",    path},
                {"Content", content}
            };
        }

        /// <summary>Generates a Trace Log.</summary>
        /// <remarks>This method is typically used to create and retrieve detailed log entries for
        /// diagnostic or monitoring purposes. The returned dictionary provides both the storage location and the
        /// content of the log entry for further processing or display.</remarks>
        /// <param name="logType">The type of log to generate.</param>
        /// <param name="traceLevel">The <see cref="Configuration.WsvcConfiguration.TraceLevel"/> of the log</param>
        /// <param name="avtrEnv">The Avatar environment that the Tingen Web Service has interfaced with.</param>
        /// <param name="exeAsm">The name of the assembly generating the log entry.</param>
        /// <param name="fromPath">The full path of the file being logged.</param>
        /// <param name="fromMethod">The name of the method being logged.</param>
        /// <param name="fromLine">The line number being logged.</param>
        /// <param name="logMsg">The log message, which defaults to an empty string if not provided.</param>
        /// <returns>A dictionary containing the log path and content.</returns>
        public static Dictionary<string, string> TraceLog(string logType, int traceLevel, string avtrEnv, string exeAsm, string fromPath, string fromMethod, int fromLine, string logMsg = "")
        {
            string path    = FullPath(avtrEnv, logType);
            string content = DetailedContent(logType, avtrEnv, exeAsm, fromPath, fromMethod, fromLine, logMsg);

            return new Dictionary<string, string>
            {
                {"Path",    path},
                {"Content", content}
            };
        }

        /// <summary>Generates the base path for a log.</summary>
        /// <param name="avtrEnv">The Avatar environment that the Tingen Web Service has interfaced with.</param>
        /// <param name="logType">The type of log to generate.</param>
        /// <returns>The base path for the log.</returns>
        /// <value>Example: "C:\Tingen_Data\WebService\UAT\Logs\Debug"</value>
        private static string BasePath(string avtrEnv, string logType)
        {
            return $@"C:\Tingen_Data\WebService\{avtrEnv}\Logs\{logType}";
        }

        /// <summary>Generates the full path for a log.</summary>
        /// <param name="avtrEnv">The Avatar environment that the Tingen Web Service has interfaced with.</param>
        /// <param name="logType">The type of log to generate.</param>
        /// <returns>The full path for the log.</returns>
        /// <value>Example: "C:\Tingen_Data\WebService\UAT\Logs\Debug\250519123322.debug"</value>
        private static string FullPath(string avtrEnv, string logType)
        {
            string basePath = BasePath(avtrEnv, logType);
            string fileName = $"{DateTime.Now:yyMMddHHmmssfffffff}.{logType}";

            return $@"{basePath}\{fileName}";
        }

        /// <summary>Generates a basic log header.</summary>
        /// <param name="logType">The type of log to generate.</param>
        /// <returns>A string containing a basic log header.</returns>
        private static string BasicHeader(string logType)
        {
            string dateTimeStamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            return $"========================================{Environment.NewLine}" +
                   $"{logType} Log{Environment.NewLine}" +
                   $"========================================{Environment.NewLine}" +
                   $"{dateTimeStamp}{Environment.NewLine}" +
                   $"----------------------------------------{Environment.NewLine}";
        }

        /// <summary>Generates a detailed log header.</summary>
        /// <param name="logType">The type of log to generate.</param>
        /// <param name="exeAsm">The name of the assembly generating the log entry.</param>
        /// <param name="fromPath">The full path of the file being logged.</param>
        /// <param name="fromMethod">The name of the method being logged.</param>
        /// <param name="fromLine">The line number being logged.</param>
        /// <returns>A string containing a detailed log header.</returns>
        private static string DetailedHeader(string logType, string exeAsm, string fromPath, string fromMethod, int fromLine)
        {
            string fromClass = GetFromClassName(fromPath);
            string logHeader = BasicHeader(logType);

            return logHeader +
                   $"[ASSEMBLY] {exeAsm}{Environment.NewLine}" +
                   $"   [CLASS] {fromClass}{Environment.NewLine}" +
                   $"  [METHOD] {fromMethod}{Environment.NewLine}" +
                   $"    [LINE] {fromLine}{Environment.NewLine}" +
                   Environment.NewLine;
        }

        /// <summary>Generates content for a basic log.</summary>
        /// <param name="logType">The type of log to generate.</param>
        /// <param name="logMsg">The log message, which defaults to an empty string if not provided.</param>
        /// <returns>A string that contains basic log content.</returns>
        private static string BasicContent(string logType, string logMsg = "")
        {
            string logHeader = BasicHeader(logType);

            return logHeader +
                   Environment.NewLine +
                   $"[MESSAGE] {logMsg}";
        }

        /// <summary>Generates content for a detailed log.</summary>
        /// <param name="logType">The type of log to generate.</param>
        /// <param name="avtrEnv">The environment or context in which the log is generated.</param>
        /// <param name="asmName">The name of the assembly where the log originates.</param>
        /// <param name="fromPath">The full path of the file being logged.</param>
        /// <param name="fromMethod">The name of the method being logged.</param>
        /// <param name="fromLine">The line number being logged.</param>
        /// <param name="logMsg">The log message, which defaults to an empty string if not provided.</param>
        /// <returns>A string that contains basic log content.</returns>
        private static string DetailedContent(string logType, string avtrEnv, string asmName, string fromPath, string fromMethod, int fromLine, string logMsg = "")
        {
            string fromClass = GetFromClassName(fromPath);
            string logHeader = DetailedHeader(logType, asmName, fromClass, fromMethod, fromLine);

            return logHeader +
                   Environment.NewLine +
                   $"[MESSAGE] {logMsg}";
        }

        /// <summary>Extracts the class name from a given file path.</summary>
        /// <remarks>
        ///     <para>
        ///     The full file path of the class is passed to this method, but we<br/>
        ///     just need the class name.
        ///     </para>
        /// </remarks>
        /// <param name="fromPath">The path from which to extract the class name.</param>
        /// <returns>The name of the class.</returns>
        private static string GetFromClassName(string fromPath)
        {
            return fromPath.Split('\\').Last();
        }
    }
}