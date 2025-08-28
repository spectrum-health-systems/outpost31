// =============================================================================
// Outpost31.Core.Admin.Testing.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250828_code
// u250828_documentation
// =============================================================================

using System.Reflection;
using Outpost31.Core.Logger;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Admin
{
    /// <summary>Provides testing and debugging operations.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Admin.xml' path='Core.Admin/Class[@name="Testing"]/ClassDescription/*'/>
    /// </remarks>
    internal static class Testing
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Runs regression tests.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Core.Admin.xml' path='Core.Admin/Class[@name="Testing"]/Regression/*'/>
        /// </remarks>
        /// <param name="sentOptionObject">The <see cref="OptionObject2015"/> sent from Avatar.</param>
        /// <param name="sentScriptParameter">The original Script Parameter that is sent from Avatar.</param>
        /// <param name="wsvcVer">The current version of the Tingen Web Service.</param>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/>Avatar system that the Tingen Web Service will interface with.</param>
        internal static void Regression(OptionObject2015 sentOptionObject, string sentScriptParameter, string wsvcVer, string avatarSystem)
        {
            GenerateAppLogs(avatarSystem, 0);
        }

        /// <summary>Generates various application logs.</summary>
        /// <remarks>
        ///     <include file='AppData/XmlDoc/Core.Admin.xml' path='Core.Admin/Class[@name="Testing"]/GenerateAppLogs/*'/>
        /// </remarks>
        /// <param name="avatarSystem">The identifier for the avatar system or application context in which the logging operations are performed.</param>
        /// <param name="msec">Pause, in milliseconds.</param>
        internal static void GenerateAppLogs(string avatarSystem, int msec)
        {
            //10 file
            LogAppEvent.Primeval(avatarSystem, msec);

            LogAppEvent.Critical(avatarSystem, ExeAsmName, msec, logName: "Regression test", logBody: "Regression test");
            LogAppEvent.Critical(avatarSystem, ExeAsmName, msec, logName: "Regression test", logBody: "");
            LogAppEvent.Critical(avatarSystem, ExeAsmName, msec);

            LogAppEvent.Debuggler(avatarSystem, ExeAsmName);
            LogAppEvent.Debuggler(avatarSystem, ExeAsmName, "Regression test");

            LogAppEvent.Error(avatarSystem, ExeAsmName, "Regression test");
            LogAppEvent.Error(avatarSystem, ExeAsmName, "Regression test", "000");
            LogAppEvent.Error(avatarSystem, ExeAsmName);

            LogAppEvent.Trace(avatarSystem, ExeAsmName);
        }
    }
}