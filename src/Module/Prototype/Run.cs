// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                        Module.Prototype.Run.cs

// u250430_code
// u250430_documentation

using ScriptLinkStandard.Objects;

namespace Outpost31.Module.Prototype
{
    /// <summary>Handles prototype requests.</summary>
    /// <include file='AppData/XmlDoc/Module.Prototype.xml' path='Module.Prototype/Class[@name="Run"]/ClassDescription/*'/>
    public class Run
    {
        /// <summary>Determines where to send prototype requests.</summary>
        /// <param name="sentOptObj">The original OptionObject sent from Avatar.</param>
        /// <param name="sentSlnkScriptParam">The original Script Parameter sent from Avatar.</param>
        /// <returns>A finalized OptionObject.</returns>
        /// <include file='AppData/XmlDoc/Module.Prototype.xml' path='Module.Prototype/Class[@name="Run"]/Code/*'/>
        public static OptionObject2015 Code(OptionObject2015 sentOptObj, string sentSlnkScriptParam)
        {
            if (sentSlnkScriptParam == "_pDocSysCodeDenyAccessToForm")
            {
                return DocSysCode.DenyAccessToForm(sentOptObj, sentSlnkScriptParam); // should be "returnOptObj = Session.WorkOptObj", or something like that.
            }
            else
            {
                return sentOptObj; // should be "returnOptObj = Session.WorkOptObj", or something like that.
            } 
        }
    }
}