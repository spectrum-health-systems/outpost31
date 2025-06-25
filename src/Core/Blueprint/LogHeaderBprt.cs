/* Outpost31.Core.Blueprint.LogDetailBrpt.cs
 * u250625_code
 * u250625_documentation
 */

using System.IO;

namespace Outpost31.Core.Blueprint
{
    /// <summary>Blueprints for log headers.</summary>
    public class LogHeaderBprt
    {
        public static string BasicHeader()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Tinplate\Log\log-header.tinplate");
        }
    }
}
