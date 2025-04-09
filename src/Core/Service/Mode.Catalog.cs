//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                    Core.Service.Mode.Catalog.cs

// u250409_code
// u250409_documentation

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outpost31.Core.Service
{
    public partial class Mode
    {
        /// <summary>Valid Tingen Web Service modes.</summary>
        /// <returns>A dictionary of valid Tingen Web Service modes.</returns>
        internal static List<string> cat_ValidTngnModes() => new List<string>()
        {
            "ENABLED",
            "DISABLED",
            "PASSTHROUGH"
        };
    }
}