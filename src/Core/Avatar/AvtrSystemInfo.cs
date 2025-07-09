/* Outpost31.Core.Avatar.AvtrSystemInfo.cs
 * u250709_code
 * u250709_documentation
 */

namespace Outpost31.Core.Avatar
{
    /// <summary>Logic for Avatar system/system codes/environments/etc.</summary>
    /// <remarks>TBD</remarks>
    /// <seealso href="https://github.com/spectrum-health-systems/tingen-documentation-project">Tingen Documentation Project</seealso>
    /// <seealso href="https://spectrum-health-systems.github.io/tingen-documentation-project/api">Tingen API Documentation</seealso>
    public class AvtrSystemInfo
    {
        /// <summary>The Avatar System that the Tingen Web Service will interface with.</summary>
        /// <remarks>
        ///     The Avatar <i>System</i> determines what Avatar environment the Tingen Web Service will interface with.<br/>
        ///     <br/>
        ///     Netsmart defines the following Avatar Systems when deploying Avatar at an organization:
        ///     <list type="bullet">
        ///         <item>LIVE</item>
        ///         <item>UAT</item>
        ///         <item>SBOX</item>
        ///         <item>BUILD</item>
        ///     </list>
        /// </remarks>
        /// <value>The Tingen Web Service works with the <c>LIVE</c> or <c>UAT</c> Avatar Systems.</value>
        public string AvtrSys { get; set; }

        /// <summary>The Avatar System Code used to login to Avatar.</summary>
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