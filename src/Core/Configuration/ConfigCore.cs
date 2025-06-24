/* Outpost31.Core.Runtime.CoreConfiguration.cs
 * u250624_code
 * u250624_documentation
 */

namespace Outpost31.Core.Runtime
{
    public class ConfigCore
    {
            public string TraceLevel { get; set; }

            public static ConfigCore New()
            {
                return new ConfigCore
                {
                    TraceLevel = "1"
                };
            }
     
    }
}