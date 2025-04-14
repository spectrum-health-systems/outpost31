// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                          Core.Prototype.Run.cs

// u250414_code
// u250414_documentation

using ScriptLinkStandard.Objects;

namespace Outpost31.Module.Prototype
{
    /// <summary>Run things.</summary>
    public class Run
    {
        /// <summary>Code</summary>
        /// <param name="sentOptObj"></param>
        /// <param name="sentSlnkScriptParam"></param>
        /// <returns></returns>
        public static OptionObject2015 Code(OptionObject2015 sentOptObj, string sentSlnkScriptParam)
        {
            return sentSlnkScriptParam == "_pDocSysCodeDenyAccessToForm"
                ? DocSysCode.DenyAccessToForm(sentOptObj, sentSlnkScriptParam)
                : sentOptObj;
        }
    }
}