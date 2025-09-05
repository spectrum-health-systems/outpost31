// =============================================================================
// Outpost31.Core.Session.Instance.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250905_code
// u250905_documentation
// =============================================================================

using System;
using System.Collections.Generic;
using System.Reflection;
using Outpost31.Core.Avatar;
using Outpost31.Core.Framework;
using Outpost31.Core.Logger;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Session
{
    public class Instance
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        public string Date { get; set; }
        public string Time { get; set; }
        public string Version { get; set; }
        public string Mode { get; set; }
        public string AvatarSystem { get; set; }
        public string AvatarUserName { get; set; }
        public Folders Folder { get; set; }
        public LogSettings LogSetting { get; set; }
        public AvatarOptionObject OptionObject { get; set; }
        public AvatarScriptParameter ScriptParameter { get; set; }

        /// <summary>A required log file component.</summary>
        //public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        public static Instance Start(OptionObject2015 originalOptionObject, string originalScriptParameter, Dictionary<string, string> runtimeConfig)
        {
            Instance session = Load(originalOptionObject, originalScriptParameter, runtimeConfig);

            Folders.CreateSessionFolder($@"{session.Folder.Session}");

            return session;
        }

        internal static Instance Load(OptionObject2015 originalOptionObject, string originalScriptParameter, Dictionary<string, string> runtimeConfig)
        {
            // Can't have a trace log here yet, but should log something.
            //LogEvent.Trace(2, traceLogLimitAsInt, runtimeConfig["AvatarSystem"], ExeAsmName, 0);

            string currentDate    = DateTime.Now.ToString("yyMMdd");
            string currentTime    = DateTime.Now.ToString("HHmm");
            string avatarUserName = originalOptionObject.OptionUserId;

            Folders folder         = Folders.Load(runtimeConfig["SystemDataFolder"], runtimeConfig["SystemWwwFolder"], avatarUserName, currentDate, currentTime);
            LogSettings logSetting = LogSettings.Load(runtimeConfig["TraceLogLimit"]);

            return new Instance()
            {
                Date           = currentDate,
                Time           = currentTime,
                Version        = runtimeConfig["Version"],
                Mode           = runtimeConfig["Mode"],
                AvatarSystem   = runtimeConfig["AvatarSystem"],
                AvatarUserName = avatarUserName,
                Folder         = folder,
                LogSetting     = logSetting,
                OptionObject   = new AvatarOptionObject()
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

        //internal static void CreateSessionFolder(string sessionFolder)
        //{
        //    if (!System.IO.Directory.Exists(sessionFolder))
        //    {
        //        System.IO.Directory.CreateDirectory(sessionFolder);
        //    }
        //}
    }
}