// =============================================================================
// Outpost31.Core.Request.Parser.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250903_code
// u250903_documentation
// =============================================================================

using System.IO;
using System.Reflection;
using Outpost31.Core.Avatar;
using Outpost31.Core.Logger;
using Outpost31.Core.Session;

namespace Outpost31.Core.Request
{
    public class Parser
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary></summary>
        /// <param name="tngnWsvcSession"></param>
        public static void ParseRequest(TngnWsvcSession tngnWsvcSession)
        {
            LogAppEvent.Trace(2, tngnWsvcSession.TraceLimit, tngnWsvcSession.AvatarSystem, ExeAsmName, 0);

            if (tngnWsvcSession.ScriptParameter.Original.ToLower().StartsWith("_p"))
            {
                ParsePrototypeRequest(tngnWsvcSession);
            }
            else if (tngnWsvcSession.ScriptParameter.Original.ToLower().StartsWith("_a"))
            {
                ParseAdminRequest(tngnWsvcSession);
            }
            else
            {
                ParseStandardRequest(tngnWsvcSession);
            }
        }


        internal static void ParsePrototypeRequest(TngnWsvcSession tngnWsvcSession)
        {
            LogAppEvent.Trace(2, tngnWsvcSession.TraceLimit, tngnWsvcSession.AvatarSystem, ExeAsmName, 0);
        }

        internal static void ParseStandardRequest(TngnWsvcSession tngnWsvcSession)
        {
            LogAppEvent.Trace(2, tngnWsvcSession.TraceLimit, tngnWsvcSession.AvatarSystem, ExeAsmName, 0);
        }

        internal static void ParseAdminRequest(TngnWsvcSession tngnWsvcSession)
        {
            LogAppEvent.Trace(2, tngnWsvcSession.TraceLimit, tngnWsvcSession.AvatarSystem, ExeAsmName, 0);

            if (tngnWsvcSession.ScriptParameter.Original.ToLower() == "_atest")
            {
                Module.Administration.Testing.Regression(tngnWsvcSession.AvatarSystem, tngnWsvcSession.TraceLimit);
                AvatarOptionObject.ToReturn(tngnWsvcSession, 3, "Regression test complete.");
            }
            else if (tngnWsvcSession.ScriptParameter.Original.ToLower() == "_adeploy")
            {
                Module.Administration.Deployment.FullDeploy(tngnWsvcSession.AvatarSystem, tngnWsvcSession.TraceLimit);
                AvatarOptionObject.ToReturn(tngnWsvcSession, 3, "Deployment complete!");
            }
            else if (tngnWsvcSession.ScriptParameter.Original.ToLower() == "_arefresh")
            {
                Module.Administration.Deployment.RefreshAppData(tngnWsvcSession.AvatarSystem, tngnWsvcSession.TraceLimit);
                AvatarOptionObject.ToReturn(tngnWsvcSession, 3, "Refresh complete!");
            }
            else
            {
                // Critial log here.
                AvatarOptionObject.ToReturn(tngnWsvcSession, 3, $"Unknown request: {tngnWsvcSession.ScriptParameter.Original}");
            }
        }
    }
}