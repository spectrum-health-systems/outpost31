// =============================================================================
// Outpost31.Core.Logger.LogAppEvent.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250904_code
// u250904_documentation
// =============================================================================

using System;

namespace Outpost31.Core.Logger
{
    public class Logs
    {
        public int TraceLogLimit { get; set; }

        public static Logs Load(string traceLogLimit)
        {
            return new Logs
            {
                TraceLogLimit = Convert.ToInt32(traceLogLimit)
            };
        }
    }
}
