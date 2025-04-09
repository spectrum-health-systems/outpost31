// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                         Core.Avatar.Session.cs

// u250409_code
// u250409_documentation

using Outpost31.Core.Runtime;

using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Session
{
    /// <summary> Session logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Session.xml' path='Core.Session/Class[@name="TngnSession"]/ClassDescription/*'/>
    public partial class TngnSession
    {
        /* Class properties are defined in the TngnSession.Properties.cs partial class. */

        /// <summary>Creates a new Tingen Web Service session object.</summary>
        /// <param name="sentOptObj"></param>
        /// <param name="sentScriptParam"></param>
        /// <param name="tngnVersion"></param>
        /// <returns>A new Tingen Web Service session object.</returns>
        /// <include file='AppData/XmlDoc/Core.Session.xml' path='Core.Session/Class[@name="TngnSession"]/New/*'/>
        public static TngnSession New(OptionObject2015 sentOptObj, string sentScriptParam, string tngnVersion)
        {
            var tngnConfig = Core.Configuration.TngnConfig.New(tngnVersion);

            //validate all config



            return new TngnSession
            {
                TngnConfig   = Core.Configuration.TngnConf.New(tngnVersion),
                SentOptObj   = sentOptObj,
                WorkOptObj   = sentOptObj.Clone(),
                ReturnOptObj = null,
                ScriptParam  = sentScriptParam,
                SysCode      = sentOptObj.SystemCode
            };
        }
    }
}