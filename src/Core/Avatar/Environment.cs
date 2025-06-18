/* Outpost31.Core.Avatar.Environment.cs
 * u250618_code
 * u250618_documentation
 */

namespace Outpost31.Core.Avatar
{
    /// <summary>Avatar environment details.</summary>
    /// <seealso href="https://github.com/spectrum-health-systems/tingen-documentation-project">Tingen Documentation Project</seealso>
    public class Environment
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
        /// <value>The Tingen Web Service works with the "LIVE" or "UAT" Avatar Systems.</value>
        public string AvtrSys { get; set; }

        /// <summary>The Avatar System Code used to login to Avatar.</summary>
        /// <remarks>
        ///     The Avatar <i>System Code</i> determines(in part) what Avatar functionality a user has access to while they are logged into an Avatar <i>System</i>.<br/>
        ///     <br/>
        ///     Organizations may have many different Avatar <i>System Codes</i>, but only a few Avatar <i>Systems</i>.<br/>
        ///     In addition, the Avatar System Code may be similar or the same as the Avatar System.<br/>
        /// </remarks>
        public string AvtrSysCode { get; set; }
    }
}