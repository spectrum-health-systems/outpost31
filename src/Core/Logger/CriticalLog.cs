// =============================================================================
// Outpost31.Core.Logger.CriticalLog.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250905_code
// u250905_documentation
// =============================================================================

using System;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Outpost31.Core.Logger
{
    internal class CriticalLog
    {
        // Reason why msec is before logName and logBody: might need to specify logname/body,
        // and it's easy to define msec, but if msec is after logName/logBody, then you have
        // to specify logName/logBody to specify msec.
        internal static void CreateStandard(string baseDataFolder,
                                            string blueprintFolder,
                                            string sessionFolder,
                                            string sessionDate,
                                            string avatarUserName,
                                            string exeAsmName,
                                            int msec = 0,
                                            string logName = "Unknown critical issue",
                                            string logBody = "Unknown critical issue.",
                                            [CallerFilePath] string fromClassPath = "",
                                            [CallerMemberName] string fromMethod = "",
                                            [CallerLineNumber] int fromLine = 0)
        {
            Thread.Sleep(msec);

            var fromClass = LogEvent.GetClassName(fromClassPath);

            var proxyText = File.ReadAllText($@"{blueprintFolder}\Log\critical.blueprint");

            var logContent = proxyText.Replace("~LOG~NAME~", logName)
                                      .Replace("~CURRENT~DATE~TIME~", DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss"))
                                      .Replace("~LOG~BODY~", logBody)
                                      .Replace("~ASSEMBLY~", exeAsmName)
                                      .Replace("~CLASS~", fromClass)
                                      .Replace("~METHOD~", fromMethod)
                                      .Replace("~LINE~", fromLine.ToString());

            string sessionLogPath = $@"{sessionFolder}\{logName}-{DateTime.Now:ddHHmmss}.critical";
            LogWriter.ToLocal(sessionLogPath, logContent);

            string systemLogPath = $@"{baseDataFolder}\Log\{sessionDate}-{DateTime.Now:HHmmssffffff}-{avatarUserName}.critical";
            LogWriter.ToLocal(systemLogPath, logContent);
        }
    }
}
