// =============================================================================
// Outpost31.Core.Logger.LogAppEvent.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250905_code
// u250905_documentation
// =============================================================================

using System;

namespace Outpost31.Core.Logger
{
    public class LogSettings
    {
        public int TraceLogLimit { get; set; }

        public static LogSettings Load(string traceLogLimit)
        {
            return new LogSettings
            {
                TraceLogLimit = Convert.ToInt32(traceLogLimit)
            };
        }
    }
}
