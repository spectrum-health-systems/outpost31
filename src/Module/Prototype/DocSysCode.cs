// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                     Core.Prototype.BlockDoc.cs

// u250412_code
// u250412_documentation

/* #DEVNOTE#
 * This is prototype code for blocking the "DOC" Avatar System Code from opening specified forms.
 *
 * To use this code, pass the "_pDocSysCodeDenyAccessToForm" Script Parameter to the Tingen Web Service.
 */

using System;
using ScriptLinkStandard.Objects;

namespace Outpost31.Module.Prototype
{
    public class DocSysCode
    {
        public static OptionObject2015 DenyAccessToForm(OptionObject2015 sentOptObj)
        {
            var msg = $"Access Denied{Environment.NewLine}" +
                      Environment.NewLine +
                     "Please access this data via the Console Widget Viewer!";

            if (sentOptObj.SystemCode == "DOC")
            {
                return sentOptObj.ToReturnOptionObject(1, msg);
            }
            else
            {
                return sentOptObj.ToReturnOptionObject(0, "");
            }
        }
    }
}