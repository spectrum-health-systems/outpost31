//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██

// u250404_code
// u250404_documentation

using System.Threading;
using System;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Logger
{
    internal static partial class PrimevalLog
    {
        /// <summary>Primeval log path.</summary>
        /// <remarks>Why this is important, and why it is what it is.</remarks>
        //public static string PrimevalLogPath { get; set; } = @"C:\TingenData\Primeval";

        /* [DN01] */
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
    }
}
