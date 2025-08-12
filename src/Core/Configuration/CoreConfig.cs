/* Outpost31.Core.Configuration.CoreConfig.cs
 * u250804_code
 * u250804_documentation
 */

namespace Outpost31.Core.Runtime
{
    public class CoreConfig
    {
            public string TraceLevel { get; set; }

            public static CoreConfig New()
            {
                return new CoreConfig
                {
                    TraceLevel = "1"
                };
            }
    }
}