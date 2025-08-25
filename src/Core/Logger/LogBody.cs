/* u250825_code
 * u250825_documentation
 */

using System.IO;

namespace Outpost31.Core.Logger
{
    /// <summary>Generates log body text.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogBody"]/ClassDescription/*'/>
    /// </remarks>
    internal class LogBody
    {
        /// <summary>Generates content for a basic log.</summary>
        /// <param name="logBody">The log body, which defaults to an empty string if not provided.</param>
        /// <returns>A string that contains basic log content.</returns>
        internal static string Basic(string logBody = "")
        {
            var content = File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\App\Blueprint\Log\basic-log.body");

            return content.Replace("~LOG~BODY~", logBody);
        }
    }
}