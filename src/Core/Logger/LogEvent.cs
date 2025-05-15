// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                        Core.Logger.LogEvent.cs

// u250501_code
// u250501_documentation

using System.Collections.Generic;
using System.Runtime.CompilerServices;
using System.Threading;
using Outpost31.Core.Utility.Du;
using static System.Net.Mime.MediaTypeNames;

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

        public static void Debug(string tngnWbsvEnvironment, string asmName, [CallerFilePath] string callerFilePath = "", [CallerMemberName] string callingMethod = "", [CallerLineNumber] int methodLine = 0, string message = "No message.")
        {
            /* Trace/Debuggler Logs won't work here. */

            Dictionary<string, string> logComponent = LogComponent.CreateStandardLog("Debug", tngnWbsvEnvironment, asmName, callerFilePath, callingMethod, methodLine, message);

            WriteLogToFile(logComponent);
        }

        public static void Debuggler(string tngnWbsvEnvironment, string msg)
        {
            /* Trace/Debuggler Logs won't work here. */

            Thread.Sleep(1000); // Simulate a delay for debugging purposes
            Dictionary<string, string> logComponent = LogComponent.CreateBasicLog("Debuggler", tngnWbsvEnvironment, msg);

            WriteLogToFile(logComponent);
        }

        public static void Primeval(string tngnWbsvEnvironment, string asmName, [CallerFilePath] string callerFilePath = "", [CallerMemberName] string callingMethod = "", [CallerLineNumber] int methodLine = 0, string message = "No message.")
        {
            /* Trace/Primeval Logs won't work here. */

            Dictionary<string, string> logComponent = LogComponent.CreateStandardLog("Primeval", tngnWbsvEnvironment, asmName, callerFilePath, callingMethod, methodLine, message);

            WriteLogToFile(logComponent);
        }

        /// <summary>Creates Trace Log.</summary>
        /// <remarks>
        ///     <note title="About this method">
        ///         <list type="bullet">
        ///             <item>
        ///                 This method creates Trace Logs, which are used for debugging<br/>
        ///                 and tracking the flow of the application.
        ///             </item>
        ///             <item>
        ///                 Trace Logs can't go here because the logging infrastructure<br/>
        ///                 hasn't been initialized yet. If you need to create a log here,<br/>
        ///                 use a Debuggler Log instead.
        ///             </item>
        ///         </list>
        ///     </note>
        ///     <para>
        ///         Trace Logs are assigned a level between 0 and 9,:
        ///         <list type="table">
        ///             <item>
        ///                 <term>0</term>
        ///                 <description>None</description>
        ///              </item>
        ///             <item>
        ///                 <term>1</term>
        ///                 <description>Methods</description>
        ///              </item>
        ///             <item>
        ///                 <term>2</term>
        ///                 <description>Conditional statements</description>
        ///              </item>
        ///             <item>
        ///                 <term>3</term>
        ///                 <description>TBD.</description>
        ///              </item>
        ///             <item>
        ///                 <term>4</term>
        ///                 <description>TBD.</description>
        ///              </item>
        ///             <item>
        ///                 <term>5</term>
        ///                 <description>TBD.</description>
        ///              </item>
        ///             <item>
        ///                 <term>6</term>
        ///                 <description>TBD.</description>
        ///              </item>
        ///             <item>
        ///                 <term>7</term>
        ///                 <description>TBD.</description>
        ///              </item>
        ///             <item>
        ///                 <term>8</term>
        ///                 <description>TBD.</description>
        ///              </item>
        ///             <item>
        ///                 <term>9</term>
        ///                 <description>All</description>
        ///              </item>
        ///         </list>
        ///     </para>
        /// </remarks>
        /// <param name="traceLevel">The Trace Log level.</param>
        /// <param name="tngnWbsvEnvironment">The Avatar environment that interfaces with the Tingen Web Service.</param>
        /// <param name="asmName">The name of the assembly generating the trace.</param>
        /// <param name="callerFilePath">The full file path of the source code file that invoked the method.</param>
        /// <param name="callingMethod">The name of the method that invoked the trace.</param>
        /// <param name="methodLine">The line number in the source code file where the trace was invoked.</param>
        /// <param name="message">The message to include in the trace log. Defaults to "No message." if not specified.</param>
        public static void Trace(int traceLevel, string tngnWbsvEnvironment, string asmName, [CallerFilePath] string callerFilePath = "", [CallerMemberName] string callingMethod = "", [CallerLineNumber] int methodLine = 0, string message = "No message.")
        {
            Dictionary<string, string> logComponent = LogComponent.CreateStandardLog("Trace", tngnWbsvEnvironment, asmName, callerFilePath, callingMethod, methodLine, message);

            WriteLogToFile(logComponent);
        }

        private static void WriteLogToFile(Dictionary<string, string> logComponent)
        {
            DuFile.WriteLocal(logComponent["FullPath"], logComponent["LogContent"]);
        }
    }
}