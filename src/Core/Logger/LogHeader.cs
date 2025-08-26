/* u250825_code
 * u250825_documentation
 */

using System;
using System.IO;

namespace Outpost31.Core.Logger
{
    /// <summary>Generates log header text.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogHeader"]/ClassDescription/*'/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='TngnOpto/Class[@name="ProjectInfo"]/Callback/*'/>
    /// </remarks>
    internal static class LogHeader
    {
        /// <summary>Generates a basic log header.</summary>
        /// <param name="logType">The type of log to generate.</param>
        /// <returns>A string containing a basic log header.</returns>
        internal static string Basic(string avtrSys, string logType)
        {
            string currentDateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            var header = File.ReadAllText($@"C:\Tingen_Data\WebService\{avtrSys}\App\Blueprint\Log\basic-log.header");

            return header.Replace("~LOG~TYPE~", logType)
                         .Replace("~CURRENT~DATE~TIME~", currentDateTime);
        }
    }
}