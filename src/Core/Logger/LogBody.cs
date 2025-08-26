/* u250825_code
 * u250825_documentation
 */

using System.IO;

namespace Outpost31.Core.Logger
{
    /// <summary>Generates log body text.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogBody"]/ClassDescription/*'/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='TngnOpto/Class[@name="ProjectInfo"]/Callback/*'/>
    /// </remarks>
    internal static class LogBody
    {
        /// <summary>Generates a basic log body.</summary>
        /// <param name="logBody">The log body.</param>
        /// <returns>A string that contains basic log body.</returns>
        internal static string Basic(string avtrSys, string logBody = "")
        {
            var content = File.ReadAllText($@"C:\Tingen_Data\WebService\{avtrSys}\App\Blueprint\Log\basic-log.body");

            return content.Replace("~LOG~BODY~", logBody);
        }

        /// <summary>Generates a basic log body.</summary>
        /// <param name="logBody">The log body.</param>
        /// <returns>A string that contains basic log body.</returns>
        internal static string Detailed(string avtrSys, string logBody = "")
        {
            var content = File.ReadAllText($@"C:\Tingen_Data\WebService\{avtrSys}\App\Blueprint\Log\detailed-log.body");

            return content.Replace("~LOG~BODY~", logBody);
        }
    }
}