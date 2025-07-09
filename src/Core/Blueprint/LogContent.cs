/* Outpost31.Core.Blueprint.LogMessage.cs
 * u250709_code
 * u250709_documentation
 */

using System.IO;

namespace Outpost31.Core.Blueprint
{
    internal class LogContent
    {
        public static string BasicHeader()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Tinplate\Log\log-header.tinplate");
        }
    }
}