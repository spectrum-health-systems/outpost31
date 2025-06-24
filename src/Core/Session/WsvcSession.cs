/* Outpost31.Core.Session.WsvcSession.cs
/* u250624_code
 * u250624_documentation
 */

using Outpost31.Core.Avatar;
using Outpost31.Core.Logger;
using Outpost31.Core.Runtime;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Session
{
    /// <summary>Session logic for the Tingen Web Service.</summary>
    /// <remarks>TBD</remarks>
    ///<seealso href="https://github.com/spectrum-health-systems/tingen-documentation-project">Tingen Documentation Project</seealso>
    public class WsvcSession
    {
        public ConfigRuntime RuntimeConfig { get; set; }

        public ConfigCore CoreConfig { get; set; }

        public ConfigModule ModuleConfig { get; set; }

        /// <summary>Gets or sets the optional object associated with the avatar.</summary>
        public AvtrOptionObject OptObj { get; set; }

        /// <summary>The ScriptLink Script Parameter sent from Avatar.</summary>
        public AvtrParameter ScriptParam { get; set; }

        /// <summary>The Avatar System Code that this instance of the Tingen Web Service will interface with.</summary>
        public AvtrSystemInfo AvtrSysInfo { get; set; }

        /// <summary>Creates and initializes a new TngnWbsvSession object</summary>
        /// <param name="origOptObj">The OptionObject that is sent from Avatar.</param>
        /// <param name="origScriptParam">The Script Parameter that is sent from Avatar.</param>
        /// <param name="wsvcVer">The current version of the Tingen Web Service.</param>
        /// <returns>A new Tingen Web Service session object.</returns>
        public static WsvcSession New(OptionObject2015 origOptObj, string origScriptParam, string wsvcVer, string avtrSys)
        {
            //#DEVNOTE# We need to validate that these values are valid.
            LogEvent.Debuggler(avtrSys, $"Creating new session");

            var wsvcSession =  new WsvcSession
            {
                RuntimeConfig = ConfigRuntime.New(wsvcVer, avtrSys),
                CoreConfig    = ConfigCore.New(),
                ModuleConfig  = ConfigModule.New(),
                OptObj        = new AvtrOptionObject
                {
                    Original  = origOptObj,
                    Worker    = origOptObj.Clone(),
                    Finalized = null
                },
                ScriptParam = new AvtrParameter
                {
                    Original = origScriptParam
                },
                AvtrSysInfo = new AvtrSystemInfo
                {
                    AvtrSys = avtrSys
                },
            };

            LogEvent.Debuggler(avtrSys, $"New session created.");

            return wsvcSession;
        }
    }
}