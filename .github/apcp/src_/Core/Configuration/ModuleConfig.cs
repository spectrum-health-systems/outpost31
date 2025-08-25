/* Outpost31.Core.ModuleConfig.cs
 * u250804_code
 * u250804_documentation
 */

namespace Outpost31.Core.Runtime
{
    public class ModuleConfig
    {
        public string ModOne { get; set; }

        public static ModuleConfig New()
        {
            return new ModuleConfig
            {
                ModOne = null
            };
        }
    }
}