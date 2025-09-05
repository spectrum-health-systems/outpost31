// =============================================================================
// Outpost31.Core.Avatar.AvatarEnvironment.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250905_code
// u250905_documentation
// =============================================================================

using System.ComponentModel;

namespace Outpost31.Core.Avatar
{
    /// <summary>Logic for Avatar environment components.</summary>
    /// <remarks>
    ///     An Avatar environment consists of two components: the <see cref="AvatarSystem">Avatar System</see> and <see cref="AvatarSystemCode">Avatar System Code</see>.<br/>
    ///     <br/>
    ///     While both contain the word<i> system</i>, they are not the same! It is important to understand the difference between the two.<br/>
    ///     <br/>
    ///     For more information about Outpost31, please see the<see cref = "Outpost31.ProjectInfo"/> file.
    /// </remarks>
    internal class AvatarEnvironment
    {
        /// <summary>The Avatar System that the Tingen Web Service will interface with.</summary>
        /// <remarks><include file='AppData/XmlDoc/Manual.xml' path='Manual/Topic[@name="Avatar"]/AvatarSystem/*'/></remarks>
        /// <value>The default value is <c>UAT</c>.</value>
        public string AvatarSystem { get; set; }

        /// <summary>The Avatar System Code used to login to Avatar.</summary>
        public string AvatarSystemCode { get; set; }
    }
}