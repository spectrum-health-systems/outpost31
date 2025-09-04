// =============================================================================
// Outpost31.Module.Administration.Testing.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250904_code
// u250904_documentation
// =============================================================================

using System.Reflection;
using Outpost31.Core.Avatar;
using Outpost31.Core.Logger;
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
        internal static void Regression(string tngnWsvcDataFolder, string avatarSystem, int traceLimit)
        {
            GenerateAppLogs(tngnWsvcDataFolder, avatarSystem, traceLimit, 1000);
        }

        /// <summary>Generates various application logs.</summary>
        /// <param name="avatarSystem">The identifier for the avatar system or application context in which the logging operations are performed.</param>
        /// <param name="msec">Pause, in milliseconds.</param>
        internal static void GenerateAppLogs(string tngnWsvcDataFolder, string avatarSystem, int traceLimit, int msec)
        {
            // No logging done here.

            /* Prior to generating application logs, set the <TraceLimit> to 9. This will ensure that all trace levels are created.
             *
             * This should create 19 logfiles. If it does not, increase the msec value.
             */
            LogEvent.Primeval(avatarSystem, msec);

            LogEvent.Critical(tngnWsvcDataFolder, avatarSystem, ExeAsmName, msec, logName: "Regression test", logBody: "Regression test");
            LogEvent.Critical(tngnWsvcDataFolder, avatarSystem, ExeAsmName, msec, logName: "Regression test", logBody: "");
            LogEvent.Critical(tngnWsvcDataFolder, avatarSystem, ExeAsmName, msec);

            LogEvent.Debuggler(avatarSystem, ExeAsmName);
            LogEvent.Debuggler(avatarSystem, ExeAsmName, logBody: "Regression test");

            LogEvent.Error(avatarSystem, ExeAsmName, errorMsg: "Regression test");
            LogEvent.Error(avatarSystem, ExeAsmName, errorMsg: "Regression test", errorCode: "000");
            LogEvent.Error(avatarSystem, ExeAsmName);

            LogEvent.Trace(0, traceLimit, avatarSystem, ExeAsmName);
            LogEvent.Trace(1, traceLimit, avatarSystem, ExeAsmName);
            LogEvent.Trace(2, traceLimit, avatarSystem, ExeAsmName);
            LogEvent.Trace(3, traceLimit, avatarSystem, ExeAsmName);
            LogEvent.Trace(4, traceLimit, avatarSystem, ExeAsmName);
            LogEvent.Trace(5, traceLimit, avatarSystem, ExeAsmName);
            LogEvent.Trace(6, traceLimit, avatarSystem, ExeAsmName);
            LogEvent.Trace(7, traceLimit, avatarSystem, ExeAsmName);
            LogEvent.Trace(8, traceLimit, avatarSystem, ExeAsmName);
            LogEvent.Trace(9, traceLimit, avatarSystem, ExeAsmName);
        }
    }
}