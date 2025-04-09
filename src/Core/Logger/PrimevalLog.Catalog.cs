// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                             Core.Logger.PrimevalLog.Catalog.cs

// u250409_code
// u250409_documentation

using System;

namespace Outpost31.Core.Logger
{
    internal partial class PrimevalLog
    {
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
