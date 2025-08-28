// =============================================================================
// Outpost31.Core.Avatar.AvtrEnvironment.cs
// Logic for Avatar environment components.
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250827_code
// u250827_documentation
// =============================================================================

using System;
using System.IO;

namespace Outpost31.Core.Avatar
{
    /// <summary>Represents the components of an Avatar Environment.</summary>
    /// <remarks>
    ///   <para>
    ///     The Avatar Environment represents the <see cref="AvtrSys"><b>Avatar System</b></see> and <see cref="AvtrSysCode"><b>Avatar System <i>Code</b></i></see>.<br/>
    ///     <br/>
    ///     While both contain the word<i>System</i>, they are not the same! It is important to understand the difference between the two.<br/>
    ///   </para>
    ///   <include file='AppData/XmlDoc/ProjectInfo.xml' path='TngnOpto/Class[@name="ProjectInfo"]/Callback/*'/>
    /// </remarks>
    internal class AvtrEnvironment
    {
        /// <summary>The Avatar <i>System</i> that the Tingen Web Service will interface with.</summary>
        /// <remarks>
        ///   <para>
        ///     It is <b><i>very important</i></b> that<c>AvtrSys</c> is set correctly, otherwise lots of bad things can *and will* happen!<br/>
        ///     <include file='AppData/XmlDoc/Core.Avatar.xml' path='Core.Avatar/Class[@name="AvtrEnvironment"]/AvtrSys/*'/>
        ///   </para>
        /// </remarks>
        /// <value>Valid AvtrSys values: <c>LIVE</c>, <c>UAT</c>.</value>
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

        /// <summary>The Avatar <i>System</i> that the Tingen Web Service will interface with.</summary>
        /// <remarks>
        ///   <para>
        ///     It is <b><i>very important</i></b> that<c>AvtrSys</c> is set correctly, otherwise lots of bad things can *and will* happen!<br/>
        ///     <include file='AppData/XmlDoc/Core.Avatar.xml' path='Core.Avatar/Class[@name="AvtrEnvironment"]/AvtrSys/*'/>
        ///   </para>
        /// </remarks>
        /// <value>Valid AvtrSys values: <c>LIVE</c>, <c>UAT</c>.</value>
        public static void test()
        {

        }
    }
}