// =============================================================================
// Outpost31.Module.Administration.Testing.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250903_code
// u250903_documentation
// =============================================================================

using System.Reflection;
using Outpost31.Core.Avatar;
using Outpost31.Core.Logger;
using Outpost31.Core.Session;
using ScriptLinkStandard.Objects;

namespace Outpost31.Module.Administration
{
    /// <summary>Administrative testing functionality.</summary>
    internal class Testing
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Runs regression tests.</summary>
        /// <param name="sentOptionObject">The <see cref="OptionObject2015"/> sent from Avatar.</param>
        /// <param name="sentScriptParameter">The original Script Parameter that is sent from Avatar.</param>
        /// <param name="tngnWsvcVer">The current version of the Tingen Web Service.</param>
        /// <param name="avatarSystem">The <see cref="AvatarEnvironment.AvatarSystem"/>Avatar system that the Tingen Web Service will interface with.</param>
        internal static void Regression(string avatarSystem, int traceLimit)
        {
            GenerateAppLogs(avatarSystem, traceLimit, 1000);
        }

        /// <summary>Generates various application logs.</summary>
        /// <param name="avatarSystem">The identifier for the avatar system or application context in which the logging operations are performed.</param>
        /// <param name="msec">Pause, in milliseconds.</param>
        internal static void GenerateAppLogs(string avatarSystem, int traceLimit, int msec)
        {
            // No logging done here.

            /* Prior to generating application logs, set the <TraceLimit> to 9. This will ensure that all trace levels are created.
             *
             * This should create 19 logfiles. If it does not, increase the msec value.
             */
            LogAppEvent.Primeval(avatarSystem, msec);

            LogAppEvent.Critical(avatarSystem, ExeAsmName, msec, logName: "Regression test", logBody: "Regression test");
            LogAppEvent.Critical(avatarSystem, ExeAsmName, msec, logName: "Regression test", logBody: "");
            LogAppEvent.Critical(avatarSystem, ExeAsmName, msec);

            LogAppEvent.Debuggler(avatarSystem, ExeAsmName);
            LogAppEvent.Debuggler(avatarSystem, ExeAsmName, logBody: "Regression test");

            LogAppEvent.Error(avatarSystem, ExeAsmName, errorMsg: "Regression test");
            LogAppEvent.Error(avatarSystem, ExeAsmName, errorMsg: "Regression test", errorCode: "000");
            LogAppEvent.Error(avatarSystem, ExeAsmName);

            LogAppEvent.Trace(0, traceLimit, avatarSystem, ExeAsmName);
            LogAppEvent.Trace(1, traceLimit, avatarSystem, ExeAsmName);
            LogAppEvent.Trace(2, traceLimit, avatarSystem, ExeAsmName);
            LogAppEvent.Trace(3, traceLimit, avatarSystem, ExeAsmName);
            LogAppEvent.Trace(4, traceLimit, avatarSystem, ExeAsmName);
            LogAppEvent.Trace(5, traceLimit, avatarSystem, ExeAsmName);
            LogAppEvent.Trace(6, traceLimit, avatarSystem, ExeAsmName);
            LogAppEvent.Trace(7, traceLimit, avatarSystem, ExeAsmName);
            LogAppEvent.Trace(8, traceLimit, avatarSystem, ExeAsmName);
            LogAppEvent.Trace(9, traceLimit, avatarSystem, ExeAsmName);
        }
    }
}