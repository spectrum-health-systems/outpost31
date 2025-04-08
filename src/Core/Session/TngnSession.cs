//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███ 
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██ 
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██ 

// u250408_code
// u250408_documentation

using Outpost31.Core.Runtime;

using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Session
{
    /// <summary> Session logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Session.xml' path='Core.Session/Class[@name="TngnSession"]/ClassDescription/*'/>
    public partial class TngnSession
    {
        /// <summary> The runtime settings for the current session.</summary>
        public TngnConfiguration TngnConfig { get; set; }

        public OptionObject2015 SentOptObj { get; set; }

        public OptionObject2015 WorkOptObj { get; set; }

        public OptionObject2015 ReturnOptObj { get; set; }

        public string ScriptParam { get; set; }

        public string SysCode { get; set; }

        public static TngnSession New(OptionObject2015 sentOptObj, string sentScriptParam, string tngnVersion)
        {
            return new TngnSession
            {
                TngnConfig   = TngnConfiguration.New(tngnVersion),
                SentOptObj   = sentOptObj,
                WorkOptObj   = sentOptObj.Clone(),
                ReturnOptObj = null,
                ScriptParam  = sentScriptParam,
                SysCode      = sentOptObj.SystemCode
            };
        }
    }
}