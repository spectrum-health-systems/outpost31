// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                             Core.Logger.PrimevalLog.Catalog.cs

// u250410_code
// u250410_documentation

using System.Threading;
using System;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Logger
{
    internal static class PrimevalLog
    {
        /// <summary>Primeval log path.</summary>
        /// <remarks>Why this is important, and why it is what it is.</remarks>
        //public static string PrimevalLogPath { get; set; } = @"C:\TingenData\Primeval";

        /// <summary>Creates a Primeval log.</summary>
        /// <param name="assemblyName">The executing assembly name.</param>
        /// <param name="message">The log message</param>
        /// <param name="fromClass">The path of the calling class.</param>
        /// <param name="fromMethod">The path of the calling method</param>
        /// <param name="line">The line of code</param>
        /// <include file='XmlDoc/Outpost31.Core.Logger.PrimevalLog_doc.xml' path='Outpost31.Core.Logger.PrimevalLog/Type[@name="Method"]/Create/*'/>
        public static void Create(string primevalPath, string assemblyName, string message, string fromClass, string fromMethod, int line)
        {
            /* Trace/Primeval Logs won't work here. */

            // -DEPRECIATED- Framework.Maintenance.VerifyDirectory(PrimevalLogPath);

            var fileContent = cat_PrimevalHeader(assemblyName, fromClass, fromMethod, line.ToString(), message);
            var filePath    = $@"{primevalPath}\{DateTime.Now:yyMMddHHmmssfffffff}.primeval";

            Thread.Sleep(100);
            DuFile.WriteLocal(filePath, fileContent);
        }

        /// <summary>Removes old Primeval logs.</summary>
        /// <remarks>Not currently used.</remarks>
        public static void DevelopmentCleanup()
        {
           //Framework.Maintenance.RefreshDirectory(PrimevalLogPath);
        }

        /* [DN01] */
        /// <summary>Basic log information</summary>
        /// <param name="assemblyName">The executing assembly name.</param>
        /// <param name="callPath">The path of the calling class.</param>
        /// <param name="callMember">The path of the calling method</param>
        /// <param name="callLine">The line of code</param>
        /// <param name="message">The log message</param>
        /// <remarks>Creates standard log content string.</remarks>
        /// <returns>The basic log content.</returns>
        public static string cat_PrimevalHeader(string assemblyName, string calledClass, string calledMethod, string line, string message)
        {
            return $"[ASSEMBLY] {assemblyName}{Environment.NewLine}" +
                   $"   [CLASS] {calledClass}{Environment.NewLine}" +
                   $"  [METHOD] {calledMethod}(){Environment.NewLine}" +
                   $"    [LINE] {line}{Environment.NewLine}" +
                   Environment.NewLine +
                   $" [MESSAGE] {message}";
        }
    }
}