// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                 Core.Avatar.ScriptParameter.cs

// u250501_code
// u250501_documentation

using Outpost31.Core.Session;

namespace Outpost31.Core.Avatar
{
    public class ScriptParameter
    {
        public static void Request(TngnWbsvSession tngnWbsvSession)
        {
            if (tngnWbsvSession.SentScriptParam.ToLower().StartsWith("_p"))
            {
                Core.Request.Prototype.Parse(tngnWbsvSession);
            }
            else
            {
                Core.Request.Standard.Parse(tngnWbsvSession);
            }
        }
    }
}