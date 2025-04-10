// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                        Core.Logger.LogEvent.cs

// u250410_code
// u250410_documentation

using System.Linq;
using System.Runtime.CompilerServices;

namespace Outpost31.Core.Logger
{
    public static class LogEvent
    {
        public static void Primeval(string primevalPath, string assemblyName, string message = "Tingen primeval log", [CallerFilePath] string fromPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int line = 0)
        {
            /* Trace/Primeval Logs won't work here. */

            var fromClass = fromPath.Split('\\').Last();

            PrimevalLog.Create(primevalPath, assemblyName, message, fromClass, fromMethod, line);
        }
    }
}