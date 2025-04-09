// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                 Core.Avatar.Avatar.OptionObjects.Properties.cs

// u250409_code
// u250409_documentation

using System.Reflection;

using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Avatar
{
    /// <summary>The data structure that is used to pass information between Tingen and Avatar.</summary>
    public partial class OptionObjects
    {
        /// <summary>The original data structure sent from Avatar.</summary>
        public OptionObject2015 SentOptObj { get; set; }

        /// <summary>The data structure that (is potentially) modified during a Tingen Session.</summary>
        public OptionObject2015 WorkOptObj { get; set; }

        /// <summary>The data structure that is returned to Avatar.</summary>
        public OptionObject2015 ReturnOptObj { get; set; }

    
    }
}