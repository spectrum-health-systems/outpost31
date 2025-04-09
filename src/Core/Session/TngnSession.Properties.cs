// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                              Core.Avatar.Session.Properties.cs
// u250409_code
// u250409_documentation

using Outpost31.Core.Runtime;

using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Session
{
    public partial class TngnSession
    {
        /// <summary>The Tingen Web Service configuration.</summary>
        public TngnConfiguration TngnConfig { get; set; }

        /// <summary>The original OptionObject sent from Avatar.</summary>
        public OptionObject2015 SentOptObj { get; set; }

        /// <summary>The OptionObject that (is potentially) modified during a Tingen session.</summary>
        public OptionObject2015 WorkOptObj { get; set; }

        /// <summary>The OptionObject that is returned to Avatar. </summary>
        public OptionObject2015 ReturnOptObj { get; set; }

        /// <summary>The script parameter that is passed to the Tingen Web Service.</summary>
        public string ScriptParam { get; set; }

        /// <summary>The system code that the Tingen Web Service will interface with.</summary>
        public string SysCode { get; set; }
    }
}