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
 * This particular code is for blocking the "DOC" Avatar System Code
 *
 * To deny access to a form, add the "_pDocSysCodeDenyAccessToForm" Script Parameter to the Tingen Web Service.
 */

using System;
using ScriptLinkStandard.Objects;

namespace Outpost31.Module.Prototype
{
    public class DocSysCode
    {

        /// <summary>Deny access to the form if the System Code is "DOC".</summary>
        /// <param name="sentOptObj">The OptionObject sent from Avatar.</param>
        /// <param name="sentSlnkScriptParam">The Script Parameter sent from Avatar.</param>
        /// <remarks>Script Parameter: "_pDocSysCodeDenyAccessToForm".</remarks>
        /// <returns>An OptionObject.</returns>
        public static OptionObject2015 DenyAccessToForm(OptionObject2015 sentOptObj, string sentSlnkScriptParam)
        {
            return sentOptObj.SystemCode == "DOC"
                ? sentOptObj.ToReturnOptionObject(1, MsgAccessDenied())
                : sentOptObj.ToReturnOptionObject(0, "");
        }

        private static string MsgAccessDenied()
        {
            return "Access Denied" + Environment.NewLine +
                   Environment.NewLine +
                   "Please access this data via the Console Widget Viewer.";
        }

        private static string LogContents (OptionObject2015 sentOptObj, string sentSlnkScriptParam)
        {
            return "EntityID: " + sentOptObj.EntityID + Environment.NewLine +
                   "EpisodeNumber: " + sentOptObj.EpisodeNumber + Environment.NewLine +
                   "ErrorCode: " + sentOptObj.ErrorCode + Environment.NewLine +
                   "ErrorMesg: " + sentOptObj.ErrorMesg + Environment.NewLine +
                   "Facility: " + sentOptObj.Facility + Environment.NewLine +
                   "NamespaceName: " + sentOptObj.NamespaceName + Environment.NewLine +
                   "OptionId: " + sentOptObj.OptionId + Environment.NewLine +
                   "OptionStaffId: " + sentOptObj.OptionStaffId + Environment.NewLine +
                   "OptionUserId: " + sentOptObj.OptionUserId + Environment.NewLine +
                   "ParentNamespace: " + sentOptObj.ParentNamespace + Environment.NewLine +
                   "ServerName: " + sentOptObj.ServerName + Environment.NewLine +
                   "SystemCode: " + sentOptObj.SystemCode + Environment.NewLine +
                   "SessionToken: " + sentOptObj.SessionToken + Environment.NewLine +
                   "OptionId: " + sentOptObj.OptionId + Environment.NewLine +
                   "Script Parameter: " + sentSlnkScriptParam + Environment.NewLine;
        }
    }
}