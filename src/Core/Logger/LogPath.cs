/* u250825_code
 * u250825_documentation
 */

using System;

namespace Outpost31.Core.Logger
{
    /// <summary>Generates log file path.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogPath"]/ClassDescription/*'/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='TngnOpto/Class[@name="ProjectInfo"]/Callback/*'/>
    /// </remarks>
    internal class LogPath
    {
        /// <summary>Constructs the file path for an application log based on the specified system, log name, and log type.</summary>
        /// <param name="avtrSys">The name of the system or application for which the log is associated.</param>
        /// <param name="logType">The type of the log file, used as both a folder name and file extension (e.g., "Error", "Info").</param>
        /// <param name="logName">The name of the log file, without extension.</param>
        /// <returns>The full file path to the log file, including the directory structure and file extension.</returns>
        internal static string AppLogPath(string avtrSys, string logType, string logName = "")
        {
            return $@"C:\Tingen_Data\WebService\{avtrSys}\App\Log\{logType}\{logName}{DateTime.Now:yyMMdd-HHmmss-fffffff}.{logType.ToLower()}";
        }
    }
}