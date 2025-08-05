/* Outpost31.Core.Avatar.AvtrSystem.cs
 * u250804_code
 * u250805_documentation
 */

namespace Outpost31.Core.Avatar
{
    /// <summary>Logic for Avatar systems and system codes.</summary>
    /// <remarks>
    ///     The Tingen Web Service refers to Avatar <see cref="AvtrSystem"> <i>System</i> </see> and Avatar <see cref="AvtrSysCode"> <i>System Code</i></see>.<br/>
    ///     <br/>
    ///     While both contain the word <i>System</i>, they are not the same! It is important to understand the difference between the two.<br/>
    ///     <include file='AppData/XmlDoc/ProjectInfo.xml' path='ProjectInfo/Class[@name="Project"]/Callback/*'/>
    /// </remarks>
    public class AvtrSystem
    {
        /// <summary>The Avatar <i>System</i> that the Tingen Web Service will interface with.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/AvtrSystem.xml' path='AvtrSystem/Class[@name="System"]/Description/*'/>
        /// </remarks>
        /// <value>The Tingen Web Service works with the <c>LIVE</c> or <c>UAT</c> Avatar Systems.</value>
        public string AvtrSys { get; set; }

        /// <summary>The Avatar <i>System Code</i> used to login to Avatar.</summary>
        /// <remarks>
        ///     The Avatar <i>System Code</i> determines(in part) what Avatar functionality a user has access to while they are logged into
        ///     an Avatar <i>System</i>.<br/>
        ///     <br/>
        ///     Organizations may have many different Avatar <i>System Codes</i>, but only a few Avatar <i>Systems</i>. In addition, the
        ///     Avatar System Code may be similar or the same as the Avatar System.
        /// </remarks>
        public string AvtrSysCode { get; set; }
    }
}