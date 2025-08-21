/* Outpost31.Core.Session.WsvcSession.cs
 * u250821_code
 * u250821_documentation
 */

using Outpost31.Core.Avatar;
using Outpost31.Core.Runtime;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Session
{
    /// <summary>Session logic for the Tingen Web Service.</summary>
    /// <remarks>
    ///     The Tingen Web Service session object contains all of the information that the Tingen Web Service needs to do work.<br/>
    ///     <br/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='ProjectInfo/Class[@name="Project"]/Callback/*'/>
    /// </remarks>
    ///<seealso href="https://github.com/spectrum-health-systems/tingen-documentation-project">Tingen Documentation Project</seealso>
    public class WsvcSession
    {
        /// <summary> Runtime configuration.</summary>
        public RuntimeConfig RuntimeConfig { get; set; }

        /// <summary>Core functionality configuration.</summary>
        public CoreConfig CoreConfig { get; set; }

        /// <summary>Module configurations.</summary>
        public ModuleConfig ModuleConfig { get; set; }

        /// <summary>Gets or sets the optional object associated with the avatar.</summary>
        public AvtrOptionObject OptObj { get; set; }

        /// <summary>The ScriptLink Script Parameter sent from Avatar.</summary>
        public AvtrParameter ScriptParam { get; set; }

        /// <summary>The Avatar System Code that this instance of the Tingen Web Service will interface with.</summary>
        public AvtrSystem AvtrSysInfo { get; set; }

        /// <summary>Creates and initializes a new TngnWbsvSession object</summary>
        /// <param name="origOptObj">The OptionObject that is sent from Avatar.</param>
        /// <param name="origScriptParam">The Script Parameter that is sent from Avatar.</param>
        /// <param name="wsvcVer">The current version of the Tingen Web Service.</param>
        /// <param name="avtrSys">The Avatar <i>System</i> that the Tingen Web Service will interface with.</param>
        /// <returns>A new Tingen Web Service session object.</returns>
        public static WsvcSession New(OptionObject2015 origOptObj, string origScriptParam, string wsvcVer, string avtrSys)
        {
            //#DEVNOTE# We need to validate that these values are valid.

            var wsvcSession =  new WsvcSession
            {
                RuntimeConfig = RuntimeConfig.New(wsvcVer, avtrSys),
                CoreConfig    = CoreConfig.New(),
                ModuleConfig  = ModuleConfig.New(),
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
                AvtrSysInfo = new AvtrSystem
                {
                    AvtrSys = avtrSys
                },
            };

            return wsvcSession;
        }
    }
}