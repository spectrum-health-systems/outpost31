//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██

// u250408_code
// u250408_documentation

namespace Outpost31.Core.Avatar
{
    public class ScriptParameter
    {
        /// <summary>The original Script Parameter sent from Avatar.</summary>

        public string SentScriptParam { get; set; }

        /// <summary>Builds a new AvatarData data structure.</summary>
        /// <param name="sentOptObj">The SentOptionObject data structure sent from Avatar.</param>
        /// <param name="sentScriptParam">The SentScriptParameter sent from Avatar.</param>
        /// <returns>All of the data/information Tingen needs in order to do work.</returns>
        public static ScriptParameter Build(string sentScriptParam)
        {
            /* Trace Logs won't work here. */

            return new ScriptParameter
            {
                SentScriptParam = sentScriptParam
            };
        }
    }
}
