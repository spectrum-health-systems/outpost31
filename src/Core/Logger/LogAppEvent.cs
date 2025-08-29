// =============================================================================
// Outpost31.Core.Logger.LogAppEvent.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250829_code
// u250829_documentation
// =============================================================================

using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Outpost31.Core.Logger
{
    /// <summary>Logs an application event.</summary>
    /// <remarks>For more information about Outpost31, please see the <see cref="ProjectInfo"/> file.</remarks>
    public static class LogAppEvent
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Generate a critical log.</summary>
        /// <remarks>This is public because TngnWsvc may need to call it.</remarks>
        /// <param name="avatarSystem"></param>
        /// <param name="exeAsmName"></param>
        /// <param name="msec"></param>
        /// <param name="logName"></param>
        /// <param name="logBody"></param>
        /// <param name="fromClassPath"></param>
        /// <param name="fromMethod"></param>
        /// <param name="fromLine"></param>
        public static void Critical(string avatarSystem, string exeAsmName, int msec = 0, string logName = "Unknown critical issue", string logBody = "Unknown critical issue.", [CallerFilePath] string fromClassPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0)
        {
            Thread.Sleep(msec);

            var fromClass = GetClassName(fromClassPath);

            var proxyText = File.ReadAllText($@"C:\Tingen_Data\WebService\{avatarSystem}\AppData\Blueprint\log-critical.bp");

            var logContent = proxyText.Replace("~CURRENT~DATE~TIME~", DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss"))
                                      .Replace("~LOG~BODY~", logBody)
                                      .Replace("~ASSEMBLY~", exeAsmName)
                                      .Replace("~CLASS~", fromClass)
                                      .Replace("~METHOD~", fromMethod)
                                      .Replace("~LINE~", fromLine.ToString());

            string logPath = $@"C:\Tingen_Data\WebService\{avatarSystem}\Log\Critical\{logName}-{DateTime.Now:ddHHmmss}.critical";

            File.WriteAllText(logPath, logContent);
        }

        internal static void Debuggler(string avatarSystem, string exeAsmName, string logBody = "Standard debuggler log.", [CallerFilePath] string fromClassPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0, int msec = 0)
        {
            Thread.Sleep(msec);

            var fromClass = GetClassName(fromClassPath);

            var proxyText = File.ReadAllText($@"C:\Tingen_Data\WebService\{avatarSystem}\AppData\Blueprint\log-debuggler.bp");

            var logContent = proxyText.Replace("~CURRENT~DATE~TIME~", DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss"))
                                      .Replace("~LOG~BODY~", logBody)
                                      .Replace("~ASSEMBLY~", exeAsmName)
                                      .Replace("~CLASS~", fromClass)
                                      .Replace("~METHOD~", fromMethod)
                                      .Replace("~LINE~", fromLine.ToString());

            string logName = $"{exeAsmName}-{fromClass}-{fromMethod}-{fromLine}-{DateTime.Now:ddHHmmss}";

            string logPath = $@"C:\Tingen_Data\WebService\{avatarSystem}\Log\Debuggler\{logName}.debuggler";

            File.WriteAllText(logPath, logContent);
        }

        internal static void Error(string avatarSystem, string exeAsmName, string errorMsg = "Standard error log.", string errorCode = "---", [CallerFilePath] string fromClassPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0, int msec = 0)
        {
            Thread.Sleep(msec);

            var fromClass = GetClassName(fromClassPath);

            var proxyText = File.ReadAllText($@"C:\Tingen_Data\WebService\{avatarSystem}\AppData\Blueprint\log-error.bp");

            var logContent = proxyText.Replace("~CURRENT~DATE~TIME~", DateTime.Now.ToString("MM/dd/yyyy-HH:mm:ss"))
                                      .Replace("~ERROR~CODE~", errorCode)
                                      .Replace("~ERROR~MESSAGE~", errorMsg)
                                      .Replace("~ASSEMBLY~", exeAsmName)
                                      .Replace("~CLASS~", fromClass)
                                      .Replace("~METHOD~", fromMethod)
                                      .Replace("~LINE~", fromLine.ToString());

            var logName = $"{exeAsmName}-{fromClass}-{fromMethod}-{fromLine}-{DateTime.Now:ddHHmmss}";

            string logPath = $@"C:\Tingen_Data\WebService\{avatarSystem}\Log\Error\{logName}.error";

            File.WriteAllText(logPath, logContent);
        }

        /// <summary>Primeval logs are used when the advanced logging infrastructure isn't available.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogEvent"]/Primeval/*'/>
        /// </remarks>
        /// <param name="avatarSystem">The sys</param>
        /// <param name="logBody">The log message, which defaults to "Primeval log." if not specified.</param>
        internal static void Primeval(string avatarSystem, int msec = 0)
        {
            Thread.Sleep(msec);

            string logPath = $@"C:\Tingen_Data\WebService\{avatarSystem}\Log\Primeval\{DateTime.Now:ddHHmmss}.primeval";

            File.WriteAllText(logPath, "");
        }

        internal static void Trace(string avatarSystem, string exeAsmName, [CallerFilePath] string fromClassPath = "", [CallerMemberName] string fromMethod = "", [CallerLineNumber] int fromLine = 0, int msec = 0)
        {
            Thread.Sleep(2000);

            var fromClass = GetClassName(fromClassPath);

            var logName    = $"{exeAsmName}-{fromClass}-{fromMethod}-{fromLine}-{DateTime.Now:ddHHmmss}";
            var logPath    = $@"C:\Tingen_Data\WebService\{avatarSystem}\Log\Trace\{logName}.trace";

            File.WriteAllText(logPath, "");
        }

        internal static string GetClassName(string fromClassPath)
        {
            var fullClassPath = fromClassPath.Split(new char[] { '\\', '/' }, StringSplitOptions.RemoveEmptyEntries);
            //var className = fullClassPath.Last();
            return fullClassPath.Last().Replace(".cs", "");
        }
    }
}