// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                         Core.Logger.Builder.cs

// u250515_code
// u250515_documentation

using System;
using System.Collections.Generic;
using System.Linq;

namespace Outpost31.Core.Logger
{
    // [review]
    /// <summary>Provides methods for generating log data in various formats, including basic and standard logs.</summary>
    /// <remarks>
    ///     The <see cref="Builder"/> class offers static methods to create structured log data as
    ///     dictionaries, which include file paths and log content. These methods are designed to support different logging
    ///     scenarios, such as basic logging and detailed logging with additional metadata.
    /// </remarks>
    public class Builder
    {
        // [review]
        /// <summary>Creates a basic log entry with the specified log type, environment, and optional message.</summary>
        /// <param name="logType">The type of the log, such as "Error", "Info", or "Debug".</param>
        /// <param name="avatarEnv">The environment associated with the log, such as a specific application or system context.</param>
        /// <param name="logMsg">An optional message to include in the log. If not provided, the log will contain only the default content
        /// for the specified log type.</param>
        /// <returns>A dictionary containing the log details, where the "Path" key represents the full path to the log file, and
        /// the "Content" key contains the formatted log content.</returns>
        public static Dictionary<string, string> BuildLog(string logType, string avatarEnv, string logMsg = "")
        {
            string path    = BuildFullPath(avatarEnv, logType);
            string content = BuildContent(logType, logMsg);

            return new Dictionary<string, string>
            {
                {"Path",    path},
                {"Content", content}
            };
        }

        // [review]
        /// <summary>
        /// Creates a standardized log entry containing metadata and content for logging purposes.
        /// </summary>
        /// <remarks>
        ///     This method is designed to standardize log entries by combining metadata (such as
        ///     source information and environment) with the log message. The resulting dictionary can be used to write logs
        ///     to a file or other storage medium
        /// </remarks>
        /// <param name="logType">The type of log (e.g., "Error", "Info", "Debug") that categorizes the log entry.</param>
        /// <param name="avatarEnv">The environment or context in which the log is being generated (e.g., "Production", "Development").</param>
        /// <param name="exeAsm">The name of the executing assembly, typically used to identify the source of the log.</param>
        /// <param name="fromPath">The name of the class from which the log entry originates.</param>
        /// <param name="fromMethod">The name of the method from which the log entry originates.</param>
        /// <param name="fromLine">The line number in the source code where the log entry is generated.</param>
        /// <param name="logMsg">An optional message providing additional details about the log entry. Defaults to an empty string if not
        /// provided.</param>
        /// <returns>A dictionary containing two key-value pairs: <list type="bullet"> <item> <description> <c>"Path"</c>: The
        /// full path to the log file where the entry should be stored. </description> </item> <item> <description>
        /// <c>"Content"</c>: The formatted content of the log entry, including metadata and the optional message.
        /// </description> </item> </list></returns>
        public static Dictionary<string, string> BuildLog(string logType, string avatarEnv, string exeAsm, string fromPath, string fromMethod, int fromLine , string logMsg  = "")
        {
            string path    = BuildFullPath(avatarEnv, logType);
            string content = BuildContent(logType, avatarEnv, exeAsm, fromPath, fromMethod, fromLine, logMsg);

            return new Dictionary<string, string>
            {
                {"Path",    path},
                {"Content", content}
            };
        }

        // [review]
        /// <summary>Generates a formatted header string for a log entry.</summary>
        /// <param name="logType">The type of log (e.g., "Error", "Info", "Debug") to include in the header.</param>
        /// <returns>A string containing a formatted log header, including the log type, current date and time, and separators.</returns>
        private static string BuildHeader(string logType)
        {
            string dateTimeStamp = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            return $"========================================{Environment.NewLine}" +
                   $"{logType} Log{Environment.NewLine}" +
                   $"========================================{Environment.NewLine}" +
                   $"{dateTimeStamp}{Environment.NewLine}" +
                   $"----------------------------------------{Environment.NewLine}";
        }

        // [review]
        /// <summary>Generates a standardized log header containing metadata about the log type, assembly, class, method, and line number.</summary>
        /// <param name="logType">The type of the log (e.g., "Error", "Info", "Debug").</param>
        /// <param name="exeAsm">The name of the executing assembly.</param>
        /// <param name="fromPath">The name of the class where the log is being generated.</param>
        /// <param name="fromMethod">The name of the method where the log is being generated.</param>
        /// <param name="fromLine">The line number in the source code where the log is being generated.</param>
        /// <returns>A formatted string containing the log header with the provided metadata.</returns>
        private static string BuildHeader(string logType, string exeAsm, string fromPath, string fromMethod, int fromLine)
        {
            string fromClass = GetCallingClassName(fromPath);
            string logHeader = BuildHeader(logType);

            return logHeader +
                   $"[ASSEMBLY] {exeAsm}{Environment.NewLine}" +
                   $"   [CLASS] {fromClass}{Environment.NewLine}" +
                   $"  [METHOD] {fromMethod}{Environment.NewLine}" +
                   $"    [LINE] {fromLine}{Environment.NewLine}" +
                   Environment.NewLine;
        }

        // [review]
        /// <summary>Extracts the class name from a given file path.</summary>
        /// <param name="fromPath">The file path from which to extract the class name. Must be a valid path string.</param>
        /// <returns>The name of the class, derived from the last segment of the provided file path.</returns>
        private static string GetCallingClassName(string fromPath)
        {
            return fromPath.Split('\\').Last();
        }

        // [review]
        /// <summary>Constructs the base file path for storing logs based on the specified environment and log type.</summary>
        /// <param name="tngnWbsvEnvironment">The name of the environment (e.g., "Production", "Development") used to determine the directory structure.</param>
        /// <param name="logType">The type of log (e.g., "Error", "Info") used to specify the log subdirectory.</param>
        /// <returns>A string representing the full base path for the logs, combining the environment and log type.</returns>
        private static string BuildBasePath(string tngnWbsvEnvironment, string logType)
        {
            return $@"C:\Tingen_Data\WebService\{tngnWbsvEnvironment}\Logs\{logType}";
        }

        // [review]
        /// <summary>Constructs the full file path for a log file based on the specified environment and log type.</summary>
        /// <remarks>
        ///     The method appends a timestamp in the format "yyMMddHHmmssfffffff" to ensure unique
        ///     file names.
        /// </remarks>
        /// <param name="tngnWbsvEnvironment">The environment identifier used to determine the base path.</param>
        /// <param name="logType">The type of log, which determines the file extension.</param>
        /// <returns>A string representing the full file path, including the base path, a timestamp, and the log type as the file
        /// extension.</returns>
        private static string BuildFullPath(string tngnWbsvEnvironment, string logType)
        {
            string basePath = BuildBasePath(tngnWbsvEnvironment, logType);
            string fileName = $"{DateTime.Now:yyMMddHHmmssfffffff}.{logType}";

            return $@"{basePath}\{fileName}";
        }

        // [review]
        /// <summary>Constructs a formatted log entry string containing the specified log type and message.</summary>
        /// <param name="logType">The type of the log entry, such as "INFO", "ERROR", or "DEBUG".</param>
        /// <param name="message">The message to include in the log entry. This value cannot be null.</param>
        /// <returns>A formatted string that includes the log type and message, separated by a header and a newline.</returns>
        private static string BuildContent(string logType, string message)
        {
            string logHeader = BuildHeader(logType);

            return logHeader +
                   Environment.NewLine +
                   $"[MESSAGE] {message}";
        }

        // [review]
        /// <summary>Constructs a formatted log message containing metadata and the provided log content.</summary>
        /// <param name="logType">The type of log (e.g., "Error", "Warning", "Info").</param>
        /// <param name="avatarEnv">The environment or context in which the log is generated.</param>
        /// <param name="asmName">The name of the assembly where the log originates.</param>
        /// <param name="fromPath">The file path of the source code that generated the log.</param>
        /// <param name="fromMethod">The name of the method that generated the log.</param>
        /// <param name="fromLine">The line number in the source code where the log was generated.</param>
        /// <param name="logMsg">The main log message content to include in the output.</param>
        /// <returns>A formatted string containing the log metadata and message, separated by a newline.</returns>
        private static string BuildContent(string logType, string avatarEnv, string asmName, string fromPath, string fromMethod, int fromLine, string logMsg)
        {
            string fromClass = GetCallingClassName(fromPath);
            string logHeader = BuildHeader(logType, asmName, fromClass, fromMethod, fromLine);

            return logHeader +
                   Environment.NewLine +
                   $"[MESSAGE] {logMsg}";
        }
    }
}
