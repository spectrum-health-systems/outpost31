// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                    Core.Logger.LogComponent.cs

// u250430_code
// u250430_documentation

using System;
using System.Collections.Generic;
using System.Linq;

namespace Outpost31.Core.Logger
{
    public class LogComponent
    {
        public static Dictionary<string, string> CreateBasicLog(string logType, string tngnWbsvEnvironment, string message = "")
        {
            /* Trace/Primeval Logs won't work here. */

            var fullPath   = BuildLogFullPath(tngnWbsvEnvironment, logType);
            var logContent = BuildBasicContent(logType, message);

            return new Dictionary<string, string>
            {
                {"FullPath", fullPath},
                {"LogContent", logContent}
            };
        }
        public static Dictionary<string, string> CreateStandardLog(string logType, string tngnWbsvEnvironment, string asmName, string callerFilePath, string callingMethod, int methodLine, string message = "")
        {
            /* Trace/Primeval Logs won't work here. */

            var fullPath = BuildLogFullPath(tngnWbsvEnvironment, logType);
            var logContent = BuildStandardContent(logType, tngnWbsvEnvironment, asmName, callerFilePath, callingMethod, methodLine, message);

            return new Dictionary<string, string>
            {
                {"FullPath", fullPath},
                {"LogContent", logContent}
            };
        }
        /// <summary>Basic log information</summary>
        /// <param name="logType"></param>
        /// <param name="message">The log message</param>
        /// <remarks>Creates standard log content string.</remarks>
        /// <returns>The basic log content.</returns>
        private static string BuildBasicHeader(string logType)
        {
            return $"========================================{Environment.NewLine}" +
                   $"{logType} Log{Environment.NewLine}" +
                   $"========================================{Environment.NewLine}" +
                   $"{DateTime.Now:MM/dd/yyyy HH:mm:ss}{Environment.NewLine}" +
                   $"----------------------------------------{Environment.NewLine}";
        }

        /// <summary>Basic log information</summary>
        /// <param name="logType"></param>
        /// <param name="asmName">The executing assembly name.</param>
        /// <param name="callingClass"></param>
        /// <param name="callingMethod"></param>
        /// <param name="methodLine"></param>
        /// <param name="message">The log message</param>
        /// <remarks>Creates standard log content string.</remarks>
        /// <returns>The basic log content.</returns>
        private static string BuildStandardHeader(string logType, string asmName, string callingClass, string callingMethod, int methodLine)
        {
            return $"========================================{Environment.NewLine}" +
                   $"{logType} Log{Environment.NewLine}" +
                   $"========================================{Environment.NewLine}" +
                   $"{DateTime.Now:MM/dd/yyyy HH:mm:ss}{Environment.NewLine}" +
                   $"----------------------------------------{Environment.NewLine}" +
                   $"[ASSEMBLY] {asmName}{Environment.NewLine}" +
                   $"   [CLASS] {callingClass}{Environment.NewLine}" +
                   $"  [METHOD] {callingMethod}{Environment.NewLine}" +
                   $"    [LINE] {methodLine}{Environment.NewLine}" +
                   Environment.NewLine;
        }

        private static string GetCallingClassName(string callerFilePath)
        {
            return callerFilePath.Split('\\').Last();
        }

        private static string BuildLogBasePath(string tngnWbsvEnvironment, string logType)
        {
            return $@"C:\Tingen_Data\{tngnWbsvEnvironment}\{logType}";
        }

        private static string BuildLogFullPath(string tngnWbsvEnvironment, string logType)
        {
            var logBase = BuildLogBasePath(tngnWbsvEnvironment, logType);

            return $@"{logBase}\{DateTime.Now:yyMMddHHmmssfffffff}.{logType}";
        }

        private static string BuildBasicContent(string logType, string message)
        {
            var logHeader  = BuildBasicHeader(logType);

            return $"{logHeader}" +
                   Environment.NewLine +
                   $"[MESSAGE] {message}";
        }

        private static string BuildStandardContent(string logType, string tngnWbsvEnvironment, string asmName, string callerFilePath, string callingMethod, int methodLine, string message)
        {
            var callingClass = GetCallingClassName(callerFilePath);
            var logHeader    = BuildStandardHeader(logType, asmName, callerFilePath, callingMethod, methodLine);

            return $"{logHeader}" +
                   Environment.NewLine +
                   $"[MESSAGE] {message}";
        }
    }
}
