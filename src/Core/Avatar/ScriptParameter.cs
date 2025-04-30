// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                 Core.Avatar.ScriptParameter.cs

// u250430_code
// u250430_documentation

using System;

namespace Outpost31.Core.Avatar
{
    public class ScriptParameter
    {
        /// <summary>
        /// Parse the script parameter.
        /// </summary>
        /// <param name="sentScriptParam">The original Script Parameter sent from Avatar.</param>
        public static void Parse(string sentScriptParam)
        {
            /* Trace Logs won't work here. */

            var test = sentScriptParam.Split(new[] { '-' }, StringSplitOptions.RemoveEmptyEntries);
        }
    }
}

//Module.Admin.