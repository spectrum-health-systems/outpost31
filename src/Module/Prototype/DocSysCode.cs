// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                   Core.Prototype.DocSysCode.cs

// u250414_code
// u250414_documentation

/* #DEVNOTE#
 * This is prototype code!
 *
 * It's ugly! It doesn't follow best practices or style guides!
 *
 * This particular code is for blocking the "DOC" Avatar System Code from opening specified forms.
 *
 * To use this code, pass the "_pDocSysCodeDenyAccessToForm" Script Parameter to the Tingen Web Service.
 */

using System;
using System.IO;
using ScriptLinkStandard.Objects;

namespace Outpost31.Module.Prototype
{
    public class DocSysCode
    {
        public static OptionObject2015 DenyAccessToForm(OptionObject2015 sentOptObj, string sentSlnkScriptParam)
        {
            var timeStamp   = DateTime.Now.ToString("HHmmss");
            var logFilePath = $@"C:\Tingen_Data\WebService\UAT\Prototype\_pDocSysCodeDenyAccessToForm.{timeStamp}";

            File.WriteAllText(logFilePath, LogContent(sentOptObj.OptionUserId, sentOptObj.SystemCode, sentSlnkScriptParam));

            if (sentOptObj.SystemCode == "DOC")
            {
                return sentOptObj.ToReturnOptionObject(1, MsgAccessDenied());
            }
            else
            {
                return sentOptObj.ToReturnOptionObject(0, "");
            }
        }

        private static string MsgAccessDenied()
        {
            return "Access Denied" + Environment.NewLine +
                   Environment.NewLine +
                   "Please access this data via the Console Widget Viewer.";
        }

        private static string LogContent(string userName, string sysCode, string sentSlnkScriptParam)
        {
            return $"Avatar user: {userName}{Environment.NewLine}" +
                   $"Avatar system code: {sysCode}{Environment.NewLine}" +
                   $"Avatar script parameter: {sentSlnkScriptParam}{Environment.NewLine}";
        }
    }
}