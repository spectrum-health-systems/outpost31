// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                         Core.Avatar.Session.cs

// u250410_code
// u250410_documentation

using Outpost31.Core.Configuration;
using ScriptLinkStandard.Objects;
namespace Outpost31.Core.Session
{
    /// <summary> Session logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Session.xml' path='Core.Session/Class[@name="TngnSession"]/ClassDescription/*'/>
    public class TngnWbsvSession
    {
        /// <summary>The Tingen Web Service configuration.</summary>
        public TngnWbsvConfiguration TngnConfig { get; set; }

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

        /// <summary>Creates a new Tingen Web Service session object.</summary>
        /// <param name="sentOptObj"></param>
        /// <param name="sentScriptParam"></param>
        /// <param name="tngnVersion"></param>
        /// <returns>A new Tingen Web Service session object.</returns>
        /// <include file='AppData/XmlDoc/Core.Session.xml' path='Core.Session/Class[@name="TngnSession"]/New/*'/>
        public static TngnWbsvSession New(OptionObject2015 sentOptObj, string sentScriptParam, string tngnVersion)
        {
            var tngnConfig = Core.Configuration.TngnWbsvConfiguration.New(tngnVersion);

            //validate all config



            return new TngnWbsvSession
            {
                TngnConfig   = TngnWbsvConfiguration.New(tngnVersion),
                SentOptObj   = sentOptObj,
                WorkOptObj   = sentOptObj.Clone(),
                ReturnOptObj = null,
                ScriptParam  = sentScriptParam,
                SysCode      = sentOptObj.SystemCode
            };
        }
    }
}