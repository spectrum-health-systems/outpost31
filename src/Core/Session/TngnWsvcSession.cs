// =============================================================================
// Outpost31.Core.Session.TngnWsvcSession.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250903_code
// u250903_documentation
// =============================================================================

using System;
using System.Collections.Generic;
using System.Reflection;
using Outpost31.Core.Avatar;
using Outpost31.Core.Logger;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Session
{
    public class TngnWsvcSession
    {
        public string TngnWsvcVersion { get; set; }
        public string AvatarSystem { get; set; }
        public string TngnWsvcMode { get; set; }
        public int TraceLimit { get; set; }
        public AvatarOptionObject OptionObject { get; set; }
        public AvatarScriptParameter ScriptParameter { get; set; }

        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        public static TngnWsvcSession Start(OptionObject2015 originalOptionObject, string originalScriptParameter, string tngnWscvVersion, Dictionary<string, string> runtimeConfig)
        {
            // Need to convert this, since it's used as an integer elsewhere.
            int traceLimitAsInt = Convert.ToInt32(runtimeConfig["TraceLimit"]);

            LogAppEvent.Trace(2, traceLimitAsInt, runtimeConfig["AvatarSystem"], ExeAsmName, 0);

            return new TngnWsvcSession()
            {
                TngnWsvcVersion = tngnWscvVersion,
                AvatarSystem    = runtimeConfig["AvatarSystem"],
                TngnWsvcMode    = runtimeConfig["WsvcMode"],
                TraceLimit      = traceLimitAsInt,
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
    }
}