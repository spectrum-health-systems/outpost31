// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                        Core.Logger.LogEvent.cs

// u250501_code
// u250501_documentation

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Logger
{
    /// <summary>Methods for creating different types of logs.</summary>
    public static class LogEvent
    {
        public static void Critical(string tngnWbsvEnvironment, string message = "Critical")
        {
            /* Trace/Defcon1 Logs won't work here. */
            Dictionary<string, string> logComponent = LogComponent.CreateBasicLog("Critical", tngnWbsvEnvironment, message);

            WriteLogToFile(logComponent);
        }

        public static void Debuggler(string tngnWbsvEnvironment, string asmName, [CallerFilePath] string callerFilePath = "", [CallerMemberName] string callingMethod = "", [CallerLineNumber] int methodLine = 0, string message = "No message.")
        {
            /* Trace/Debuggler Logs won't work here. */

            Dictionary<string, string> logComponent = LogComponent.CreateStandardLog("Debuggler", tngnWbsvEnvironment, asmName, callerFilePath, callingMethod, methodLine, message);

            WriteLogToFile(logComponent);
        }

        public static void Primeval(string tngnWbsvEnvironment, string asmName, [CallerFilePath] string callerFilePath = "", [CallerMemberName] string callingMethod = "", [CallerLineNumber] int methodLine = 0, string message = "No message.")
        {
            /* Trace/Primeval Logs won't work here. */

            Dictionary<string, string> logComponent = LogComponent.CreateStandardLog("Primeval", tngnWbsvEnvironment, asmName, callerFilePath, callingMethod, methodLine, message);

            WriteLogToFile(logComponent);
        }

        public static void Trace(string tngnWbsvEnvironment, string asmName, [CallerFilePath] string callerFilePath = "", [CallerMemberName] string callingMethod = "", [CallerLineNumber] int methodLine = 0, string message = "No message.")
        {
            /* Trace/Debuggler Logs won't work here. */

            Dictionary<string, string> logComponent = LogComponent.CreateStandardLog("Trace", tngnWbsvEnvironment, asmName, callerFilePath, callingMethod, methodLine, message);

            WriteLogToFile(logComponent);
        }

        private static void WriteLogToFile(Dictionary<string, string> logComponent)
        {
            DuFile.WriteLocal(logComponent["FullPath"], logComponent["LogContent"]);
        }
    }
}