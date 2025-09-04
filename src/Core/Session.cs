// =============================================================================
// Outpost31.Core.Session.Session.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250904_code
// u250904_documentation
// =============================================================================

using System;
using System.Collections.Generic;
using System.Reflection;
using Outpost31.Core.Avatar;
using Outpost31.Core.Framework;
using Outpost31.Core.Logger;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core
{
    public class Session
    {
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        public string UserId { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public string Version { get; set; }
        public string AvatarSystem { get; set; }
        public string Mode { get; set; }

        public Folders Folder { get; set; }
        public Logs Log { get; set; }
        public AvatarOptionObject OptionObject { get; set; }
        public AvatarScriptParameter ScriptParameter { get; set; }

        /// <summary>A required log file component.</summary>
        //public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        public static Session Start(OptionObject2015 originalOptionObject, string originalScriptParameter, Dictionary<string, string> runtimeConfig)
        {
            Session session = Load(originalOptionObject, originalScriptParameter, runtimeConfig);

            CreateSessionFolder($@"{session.Folder.Session}");

            return session;
        }

        internal static Session Load(OptionObject2015 originalOptionObject, string originalScriptParameter, Dictionary<string, string> runtimeConfig)
        {
            // Can't have a trace log here yet, but should log something.
            //LogEvent.Trace(2, traceLogLimitAsInt, runtimeConfig["AvatarSystem"], ExeAsmName, 0);

            var sessionDate = DateTime.Now.ToString("yyMMdd");
            var sessionTime = DateTime.Now.ToString("HHmmss");

            return new Session()
            {
                Date  = sessionDate,
                Time  = sessionTime,
                Version      = runtimeConfig["Version"],
                AvatarSystem = runtimeConfig["AvatarSystem"],
                Mode         = runtimeConfig["Mode"],
                Folder       = Folders.Load(runtimeConfig["WwwFolder"], runtimeConfig["DataFolder"], sessionDate),
                Log          = Logs.Load(runtimeConfig["TraceLogLimit"]),
                OptionObject = new AvatarOptionObject()
                {
                    Original  = originalOptionObject,
                    Worker    = originalOptionObject.Clone(),
                    Completed = null
                },
                ScriptParameter = new AvatarScriptParameter()
                {
                    Original = originalScriptParameter
                },
            };
        }

        internal static void CreateSessionFolder(string sessionFolder)
        {
            if (!System.IO.Directory.Exists(sessionFolder))
            {
                System.IO.Directory.CreateDirectory(sessionFolder);
            }
        }
    }
}