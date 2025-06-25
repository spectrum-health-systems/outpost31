/* Outpost31.Core.Configuration.ConfigCore.cs
 * u250625_code
 * u250625_documentation
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