/* Outpost31.Core.Blueprint.LogMessage.cs
 * u250804_code
 * u250804_documentation
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