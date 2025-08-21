/* Outpost31.Core.Avatar.AvtrSystem.cs
 * u250804_code
 * u250805_documentation
 */

namespace Outpost31.Core.Avatar
{
    /// <summary>Logic for Avatar systems and system codes.</summary>
    /// <remarks>
    ///     The Tingen Web Service refers to Avatar <see cref="AvtrSys"> <i>System</i> </see> and Avatar <see cref="AvtrSysCode"> <i>System <b>Code</b></i></see>.<br/>
    ///     <br/>
    ///     While both contain the word <i>System</i>, they are not the same! It is important to understand the difference between the two.<br/>
    ///     <include file='AppData/XMLDoc/ProjectInfo.xml' path='ProjectInfo/Class[@name="Project"]/Callback/*'/>
    /// </remarks>
    public class AvtrSystem
    {
        /// <summary>The Avatar <i>System</i> that the Tingen Web Service will interface with.</summary>
        /// <remarks>
        ///     Common Avatar <i>Systems</i> are <c>LIVE</c>, <c>UAT</c>, <c>SBOX</c>, <c>BUILD</c>.
        /// </remarks>
        /// <value>The Tingen Web Service works with the <c>LIVE</c> or <c>UAT</c> Avatar Systems.</value>
        public string AvtrSys { get; set; }

        /// <summary>The Avatar  <i>System <b>Code</b></i> used to login to Avatar.</summary>
        /// <remarks>
        ///     The Avatar <i>System Code</i> determines (in part) what Avatar functionality a user has access to while they are logged into
        ///     an Avatar <i>System</i>.<br/>
        ///     <br/>
        ///     Organizations may have many different Avatar <i>System Codes</i>, but only a few Avatar <see cref="AvtrSystem"> <i>Systems</i></see>.<br/>
        ///     <br/>
        ///     In addition, the Avatar System Code may be similar or the same as the Avatar System.
        /// </remarks>
        public string AvtrSysCode { get; set; }
    }
}