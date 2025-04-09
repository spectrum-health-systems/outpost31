//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                               Core.Avatar.SystemCode.Catalog.cs

// u250409_code
// u250409_documentation

using System.Collections.Generic;

namespace Outpost31.Core.Avatar
{
    public partial class SystemCode
    {
        /// <summary>Tingen Web Service valid Avatar System Codes.</summary>
        /// <returns>A list of Avatar System Codes that can be used with the Tingen Web Service.</returns>
        internal static List<string> cat_ValidSystemCodes() => new List<string>()
        {
            "LIVE",
            "UAT"
        };
    }
}