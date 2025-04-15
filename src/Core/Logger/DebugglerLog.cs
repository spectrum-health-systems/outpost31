// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                       Core.Logger.Debuggler.cs

// u250415_code
// u250415_documentation

using System;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Logger
{
    /// <summary>What is a Debuggler log?</summary>
    public class DebugglerLog
    {
        /// <summary>Creates a Debuggler log.</summary>
        /// <param name="assemblyName">The executing assembly name.</param>
        /// <param name="message">The log message</param>
        /// <param name="fromClass">The path of the calling class.</param>
        /// <param name="fromMethod">The path of the calling method</param>
        /// <param name="line">The line of code</param>
        public static void Create(string pathPrefix, string assemblyName, string message, string fromClass, string fromMethod, int line)
        {
            /* Trace/Debuggler Logs won't work here. */

            var fileContent = DebugglerHeader(assemblyName, fromClass, fromMethod, line.ToString(), message);
            var fullPath    = $@"{pathPrefix}\{DateTime.Now:yyMMddHHmmssfffffff}.debuggler";

            DuFile.WriteLocal(fullPath, fileContent);
        }

        /// <summary>Basic log information</summary>
        /// <param name="asmName">The executing assembly name.</param>
        /// <param name="callPath">The path of the calling class.</param>
        /// <param name="callMember">The path of the calling method</param>
        /// <param name="callLine">The line of code</param>
        /// <param name="message">The log message</param>
        /// <remarks>Creates standard log content string.</remarks>
        /// <returns>The basic log content.</returns>
        private static string DebugglerHeader(string asmName, string calledClass, string calledMethod, string methodLine, string message)
        {
            return $"[ASSEMBLY] {asmName}{Environment.NewLine}" +
                   $"   [CLASS] {calledClass}{Environment.NewLine}" +
                   $"  [METHOD] {calledMethod}(){Environment.NewLine}" +
                   $"    [LINE] {methodLine}{Environment.NewLine}" +
                   Environment.NewLine +
                   $" [MESSAGE] {message}";
        }
    }
}
