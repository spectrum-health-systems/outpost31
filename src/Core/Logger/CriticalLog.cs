using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Outpost31.Core.Logger
{
    internal class CriticalLog
    {
        internal static void Create(string tngnWsvcDataFolder, string exeAsmName, int msec = 0, string logName = "Unknown critical issue", string logBody = "Unknown critical issue.", [CallerFilePath] string fromClassPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0)
        {
            Thread.Sleep(msec);

            var fromClass = LogEvent.GetClassName(fromClassPath);

            var proxyText = File.ReadAllText($@"{tngnWsvcDataFolder}\AppData\Blueprint\log-critical.bp");

            var logContent = proxyText.Replace("~CURRENT~DATE~TIME~", DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss"))
                                      .Replace("~LOG~BODY~", logBody)
                                      .Replace("~ASSEMBLY~", exeAsmName)
                                      .Replace("~CLASS~", fromClass)
                                      .Replace("~METHOD~", fromMethod)
                                      .Replace("~LINE~", fromLine.ToString());

            string logPath = $@"{tngnWsvcDataFolder}\Log\Critical\{logName}-{DateTime.Now:ddHHmmss}.critical";

            File.WriteAllText(logPath, logContent);
        }
    }
}
