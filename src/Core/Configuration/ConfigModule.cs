/* Outpost31.Core.ConfigModule.cs
 * u250625_code
 * u250625_documentation
 */


using System.IO;
using System.Text.Json;
using Outpost31.Core.Logger;

namespace Outpost31.Core.Runtime
{
    public class ConfigModule
    {
        public string ModOne { get; set; }

        public static ConfigModule New()
        {
            return new ConfigModule
            {
                ModOne = null
            };
        }
    }
}