// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                        Core.Logger.LogEvent.cs

// u250414_code
// u250414_documentation

using System.Linq;
using System.Runtime.CompilerServices;

namespace Outpost31.Core.Logger
{
    /// <summary>Methods for creating different types of logs.</summary>
    public static class LogEvent
    {
        public static void Debuggler(string filePath, string asmName, string message = "Tingen Web Service Debuggler Log", [CallerFilePath] string callerFilePath = "", [CallerMemberName] string callerMemberName = "", [CallerLineNumber] int callerLineNumber = 0)
        {
            /* Trace/Primeval Logs won't work here. */

            var callerClassName = GetCallerClassName(callerFilePath);

            DebugglerLog.Create(filePath, asmName, message, callerClassName, callerMemberName, callerLineNumber);
        }

        public static void Defcon1(string pathPrefix, string message = "Tingen Web Service Defcon 1 Log")
        {
            /* Trace/Primeval Logs won't work here. */

            DefconLog.CreateDefcon1(pathPrefix, message);
        }

        public static void Primeval(string filePath, string assemblyName, string message = "Tingen Web Service Primeval Log", [CallerFilePath] string callerFilePath = "", [CallerMemberName] string callerMemberName = "", [CallerLineNumber] int callerLineNumber = 0)
        {
            /* Trace/Primeval Logs won't work here. */

            var callerClassName = GetCallerClassName(callerFilePath);

            PrimevalLog.Create(filePath, assemblyName, message, callerClassName, callerMemberName, callerLineNumber);
        }

        private static string GetCallerClassName(string callerFilePath)
        {
            return callerFilePath.Split('\\').Last();
        }
    }
}