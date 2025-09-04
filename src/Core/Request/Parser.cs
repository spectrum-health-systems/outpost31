// =============================================================================
// Outpost31.Core.Request.Parser.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250904_code
// u250904_documentation
// =============================================================================

using System.Reflection;

namespace Outpost31.Core.Request
{
    public class Parser
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary></summary>
        /// <param name="session"></param>
        public static void ParseRequest(Session session)
        {
           // LogEvent.Trace(2, tngnWsvcSession.TraceLimit, tngnWsvcSession.AvatarSystem, ExeAsmName, 0);

            if (session.ScriptParameter.Original.ToLower().StartsWith("_p"))
            {
                ParsePrototypeRequest(session);
            }
            else if (session.ScriptParameter.Original.ToLower().StartsWith("_a"))
            {
                ParseAdminRequest(session);
            }
            else
            {
                ParseStandardRequest(session);
            }
        }


        internal static void ParsePrototypeRequest(Session session)
        {
            //LogEvent.Trace(2, session.TraceLimit, session.AvatarSystem, ExeAsmName, 0);
        }

        internal static void ParseStandardRequest(Session session)
        {
            //LogEvent.Trace(2, session.TraceLimit, session.AvatarSystem, ExeAsmName, 0);
        }

        internal static void ParseAdminRequest(Session session)
        {
            //LogEvent.Trace(2, session.TraceLimit, session.AvatarSystem, ExeAsmName, 0);

            if (session.ScriptParameter.Original.ToLower() == "_atest")
            {
                Module.Administration.Testing.Regression(session.Folder.Data, session.AvatarSystem, session.Log.TraceLogLimit);
                Core.Avatar.AvatarOptionObject.ToReturn(session, 3, "Regression test complete.");
            }
            else if (session.ScriptParameter.Original.ToLower() == "_adeploy")
            {
                Module.Administration.Deployment.FullDeploy(session.Folder.Data, session.AvatarSystem, session.Log.TraceLogLimit);
                Core.Avatar.AvatarOptionObject.ToReturn(session, 3, "Deployment complete!");
            }
            else if (session.ScriptParameter.Original.ToLower() == "_arefresh")
            {
                Module.Administration.Deployment.RefreshAppData(session.AvatarSystem, session.Log.TraceLogLimit);
                Core.Avatar.AvatarOptionObject.ToReturn(session, 3, "Refresh complete!");
            }
            else
            {
                // Critial log here.
                Core.Avatar.AvatarOptionObject.ToReturn(session, 3, $"Unknown request: {session.ScriptParameter.Original}");
            }
        }
    }
}