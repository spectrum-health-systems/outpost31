// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                 Core.Avatar.TngnWbsvSession.cs

// u250501_code
// u250501_documentation

using Outpost31.Core.Configuration;
using Outpost31.Core.Runtime;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Session
{
    /// <summary> Session logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Session.xml' path='Core.Session/Class[@name="TngnWbsvSession"]/ClassDescription/*'/>
    public class TngnWbsvSession
    {
        public TngnWbsvRuntimeSettings TngnWbsvRuntimeSettings { get; set; }

        /// <summary>The Tingen Web Service configuration object.</summary>
        /// <remarks>The TngnWbsvConfig object contains all runtime and external configuration information.</remarks>
        public TngnWbsvConfiguration TngnWbsvConfig { get; set; }

        /// <summary>The original OptionObject sent from Avatar.</summary>
        public OptionObject2015 SentOptObj { get; set; }

        /// <summary>The OptionObject that is (potentially) modified during a Tingen session.</summary>
        public OptionObject2015 WorkOptObj { get; set; }

        /// <summary>The OptionObject that is returned to Avatar. </summary>
        public OptionObject2015 ReturnOptObj { get; set; }

        /// <summary>The ScriptLink Script Parameter sent from Avatar.</summary>
        public string SentScriptParam { get; set; }

        /// <summary>The Avatar System Code that this instance of the Tingen Web Service will interface with.</summary>
        public string TngnWbsvSysCode { get; set; }

        /// <summary>Creates and initializes a new TngnWbsvSession object</summary>
        /// <param name="sentOptObj">The OptionObject that is sent from Avatar.</param>
        /// <param name="sentSlnkScriptParam">The Script Parameter that is sent from Avatar.</param>
        /// <param name="tngnWbsvVersion">The current version of the Tingen Web Service.</param>
        /// <returns>A new Tingen Web Service session object.</returns>
        /// <include file='AppData/XmlDoc/Core.Session.xml' path='Core.Session/Class[@name="TngnWbsvSession"]/TngnWbsvSession.New/*'/>
        public static TngnWbsvSession New(OptionObject2015 sentOptObj, string sentSlnkScriptParam, string tngnWbsvVersion, string tngnWbsvEnvironment)
        {
            //#DEVNOTE# We need to validate that these values are valid.

            return new TngnWbsvSession
            {
                TngnWbsvRuntimeSettings = TngnWbsvRuntimeSettings.New(tngnWbsvVersion, tngnWbsvEnvironment),
                TngnWbsvConfig          = TngnWbsvConfiguration.New(),
                SentOptObj              = sentOptObj,
                WorkOptObj              = sentOptObj.Clone(),
                ReturnOptObj            = null,
                SentScriptParam         = sentSlnkScriptParam,
                TngnWbsvSysCode         = sentOptObj.SystemCode
            };
        }
    }
}