//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██

// u250408_code
// u250408_documentation

namespace Outpost31.Core.Avatar
{
    public class SystemCode
    {
        /// <summary>The Avatar System Code that Tingen will interface with.</summary>

        public string SysCode { get; set; }

        /// <summary>Builds a new AvatarData data structure.</summary>
        /// <param name="sentOptObj">The SentOptionObject data structure sent from Avatar.</param>
        /// <param name="sentScriptParam">The SentScriptParameter sent from Avatar.</param>
        /// <returns>All of the data/information Tingen needs in order to do work.</returns>
        public static SystemCode Build(string sentSysCode)
        {
            /* Trace Logs won't work here. */

            return new SystemCode
            {
                SysCode = sentSysCode
            };
        }
    }
}
