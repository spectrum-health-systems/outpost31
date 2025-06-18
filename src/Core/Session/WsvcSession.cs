/* Outpost31.Core.Session.TngnWbsvSession.cs
 * u250616_code
 * u250616_documentation
 */

using Outpost31.Core.Avatar;
using Outpost31.Core.Configuration;
using Outpost31.Core.Logger;
using Outpost31.Core.Runtime;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Session
{
    /// <summary> Session logic for the Tingen Web Service.</summary>
    public class WsvcSession
    {
        public WsvcRuntime WsvcRun { get; set; }

        /// <summary>The Tingen Web Service configuration object.</summary>
        /// <remarks>The TngnWbsvConfig object contains all runtime and external configuration information.</remarks>
        public TngnWbsvConfiguration WsvcConfig { get; set; }

        /// <summary>Gets or sets the optional object associated with the avatar.</summary>
        public Avatar.OptionObject OptObj { get; set; }

        /// <summary>The ScriptLink Script Parameter sent from Avatar.</summary>
        public ScriptParameter ScriptParam { get; set; }

        /// <summary>The Avatar System Code that this instance of the Tingen Web Service will interface with.</summary>
        public Environment AvtrEnv { get; set; }

        /// <summary>Creates and initializes a new TngnWbsvSession object</summary>
        /// <param name="sentOptObj">The OptionObject that is sent from Avatar.</param>
        /// <param name="sentScriptParam">The Script Parameter that is sent from Avatar.</param>
        /// <param name="wsvcVer">The current version of the Tingen Web Service.</param>
        /// <returns>A new Tingen Web Service session object.</returns>
        public static WsvcSession New(OptionObject2015 sentOptObj, string sentScriptParam, string wsvcVer, string avtrSys)
        {
            //#DEVNOTE# We need to validate that these values are valid.
            LogEvent.Debuggler(avtrSys, $"[CREATING NEW SESSION]");

            var thing =  new WsvcSession
            {
                WsvcRun    = WsvcRuntime.New(wsvcVer, avtrSys),
                WsvcConfig = TngnWbsvConfiguration.New(avtrSys),
                OptObj      = new Avatar.OptionObject
                {
                    Original    = sentOptObj,
                    Worker = sentOptObj.Clone(),
                    Finalized  = null
                },
                ScriptParam = new ScriptParameter
                {
                    Original = sentScriptParam
                },
                AvtrEnv = new Environment
                {
                    AvtrSys = avtrSys
                },
            };

            LogEvent.Debuggler(avtrSys, $"[NEW SESSION CREATED] - {sentOptObj.SystemCode}");

            return thing;

            //return new TngnWbsvSession
            //{
            //    TngnWbsvRuntimeSettings = TngnWbsvRuntimeSettings.New(tngnWbsvVersion, tngnWbsvEnvironment),
            //    TngnWbsvConfig          = TngnWbsvConfiguration.New(tngnWbsvEnvironment),
            //    SentOptObj              = sentOptObj,
            //    WorkOptObj              = sentOptObj.Clone(),
            //    ReturnOptObj            = null,
            //    SentScriptParam         = sentSlnkScriptParam,
            //    TngnWbsvSysCode         = sentOptObj.SystemCode
            //};
        }
    }
}