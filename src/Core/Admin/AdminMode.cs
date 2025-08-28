// =============================================================================
// Outpost31.Core.Admin.AdminMode.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250828_code
// u250828_documentation
// =============================================================================

using System.Reflection;
using ScriptLinkStandard.Objects;
using Outpost31.Core.Avatar;

namespace Outpost31.Core.Admin
{
    /// <summary>Logic for administrative mode options.</summary>
    /// <remarks>
    ///   For more information on AdminMode and it's settings, please see the Tingen Web Service Manual.<br/>
    ///   <br/>
    ///   For more information about Outpost31, please see the <see cref="ProjectInfo"/> file.
    /// </remarks>
    public static class AdminMode
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Determines if a administrative mode should be executed.</summary>
        /// <remarks> <include file='AppData/XmlDoc/Core.Admin.xml' path='Core.Admin/Class[@name="AdminMode"]/Parse/*'/></remarks>
        /// <param name="origOptObj">The <see cref="OptionObject2015"/> sent from Avatar.</param>
        /// <param name="origScriptParam">The original Script Parameter that is sent from Avatar.</param>
        /// <param name="tngnWsvcVer">The current version of the Tingen Web Service.</param>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/>Avatar system that the Tingen Web Service will interface with.</param>
        /// <param name="adminMode">The administrative mode setting.</param>
        public static void Parse(OptionObject2015 origOptObj, string origScriptParam, string tngnWsvcVer, string avatarSystem, string adminMode)
        {
            switch (adminMode.ToLower())
            {
                case "initialize":
                    Deployment.InitializeTngnWsvc(avatarSystem);
                    break;

                case "refreshappdata":
                    Deployment.RefreshAppData(avatarSystem);
                    break;

                case "regressiontest":
                    Testing.Regression(origOptObj, origScriptParam, tngnWsvcVer, avatarSystem);
                    break;
            }
        }
    }
}