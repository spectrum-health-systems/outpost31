// =============================================================================
// Outpost31.Core.Admin.Development.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250829_code
// u250829_documentation
// =============================================================================

using System.Reflection;

namespace Outpost31.Module.Admin
{
    public class Development
    {
        /// <summary>A required log file component.</summary>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

    }
}