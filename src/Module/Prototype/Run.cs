// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                          Core.Prototype.Run.cs

// u250412_code
// u250412_documentation

using ScriptLinkStandard.Objects;

namespace Outpost31.Module.Prototype
{
    public class Run
    {
        public static OptionObject2015 Code(OptionObject2015 sentOptObj, string sentSlnkScriptParam)
        {
            if (sentSlnkScriptParam == "_pDocSysCodeDenyAccessToForm")
            {
                return DocSysCode.DenyAccessToForm(sentOptObj, sentSlnkScriptParam);
            }
            else
            {
                return sentOptObj.ToReturnOptionObject(0, "");
            }
        }
    }


}
