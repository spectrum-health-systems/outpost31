// =============================================================================
// Outpost31.Core.Avatar.AvtrEnvironment.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250829_code
// u250829_documentation
// =============================================================================

namespace Outpost31.Core.Avatar
{
    /// <summary>Logic for Avatar environment components.</summary>
    /// <remarks>
    ///   An Avatar environment consists of two components: the <see cref="AvatarSystem">Avatar System</see> and <see cref="AvatarSystemCode">Avatar System Code</see>.<br/>
    ///   <br/>
    ///   While both contain the word <i>system</i>, they are not the same! It is important to understand the difference between the two.<br/>
    ///   <br/>
    ///   For more information about Outpost31, please see the <see cref="Outpost31.ProjectInfo"/> file.
    /// </remarks>
    internal class AvatarEnvironment
    {
        /// <summary>The Avatar System that the Tingen Web Service will interface with.</summary>
        /// <remarks>
        ///   It is <b><i>very important</i></b> that <c>AvatarSystem</c> is set correctly, otherwise lots of bad things can <i>and will</i> happen!<br/>
        ///   <br/>
        ///   Common Avatar Systems are: <c>UAT</c>, <c>LIVE</c>, <c>SBOX</c>, and<c> BUILD</c>. However, the Tingen Web Service is only<br/>
        ///   able to interface with the <b><c>UAT</c></b> and <b><c> LIVE</c></b> Avatar Systems.<br/>
        ///   <br/>
        ///   <include file='AppData/XmlDoc/Core.Avatar.xml' path='Core.Avatar/Class[@name="AvtrEnvironment"]/AvtrSys/*'/>
        /// </remarks>
        /// <value>The default value is <c>UAT</c>.</value>
        public string AvatarSystem { get; set; }

        /// <summary>The Avatar System Code used to login to Avatar.</summary>
        /// <remarks>
        ///     The Avatar <i>System Code</i> determines (in part) what Avatar functionality a user has access to while they are logged into
        ///     an Avatar <i>System</i>.<br/>
        ///     <br/>
        ///     Organizations may have many different Avatar <i>System Codes</i>, but only a few Avatar <see cref="AvatarSystem"/>.<br/>
        ///     <br/>
        ///     And just to make things confusing, sometimes an Avatar System Code may be similar or the same as an Avatar System.
        /// </remarks>
        public string AvatarSystemCode { get; set; }
    }
}