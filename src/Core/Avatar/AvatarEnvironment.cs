// =============================================================================
// Outpost31.Core.Avatar.AvatarEnvironment.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250904_code
// u250904_documentation
// =============================================================================

namespace Outpost31.Core.Avatar
{
    /// <summary>Logic for Avatar environment components.</summary>
    /// <remarks><include file='AppData/XmlDoc/Core.Avatar.xml' path='Core.Avatar/Class[@name="AvatarEnvironment"]/Description/*'/></remarks>
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