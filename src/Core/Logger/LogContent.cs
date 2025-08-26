/* u250825_code
 * u250825_documentation
 */

using System;
using Outpost31.Core.Logger;

namespace Outpost31.Core.Logger
{
    /// <summary>Generates a formatted log entry consisting of a log header and log body.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogContent"]/ClassDescription/*'/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='TngnOpto/Class[@name="ProjectInfo"]/Callback/*'/>
    /// </remarks>
    internal static class LogContent
    {
        /// <summary>Constructs a formatted log message by combining a log header and log body.</summary>
        /// <param name="avtrSys">The name of the system or application generating the log.</param>
        /// <param name="logType">The type or category of the log (e.g., "Error", "Info").</param>
        /// <param name="logBody">The content or details of the log message.</param>
        /// <returns>A formatted string containing the log header and log body, separated by a newline.</returns>
        internal static string Basic(string avtrSys, string logType, string logBody)
        {
            return $"{LogHeader.Basic(avtrSys, logType)}" +
                   Environment.NewLine +
                   $"{LogBody.Basic(avtrSys, logBody)}" +
                   Environment.NewLine +
                   $"{LogFooter.Basic(avtrSys, logBody)}";
        }

        /// <summary>Constructs a formatted log message by combining a log header and log body.</summary>
        /// <param name="avtrSys">The name of the system or application generating the log.</param>
        /// <param name="logType">The type or category of the log (e.g., "Error", "Info").</param>
        /// <param name="logBody">The content or details of the log message.</param>
        /// <returns>A formatted string containing the log header and log body, separated by a newline.</returns>
        internal static string Detailed(string avtrSys, string logType, string logBody, string exeAsmName, string fromPath, string fromMethod, string fromLine)
        {
            return $"{LogHeader.Detailed(avtrSys, logType)}" +
                   Environment.NewLine +
                   $"{LogBody.Detailed(avtrSys, logBody)}" +
                   Environment.NewLine +
                   $"{LogFooter.Detailed(avtrSys, avtrSys, exeAsmName, fromPath, fromMethod, fromLine)}";
        }
    }
}