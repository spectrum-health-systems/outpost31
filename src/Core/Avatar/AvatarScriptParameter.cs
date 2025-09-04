// =============================================================================
// Outpost31.Core.Avatar.AvatarScriptParameter.cs
// https://github.com/spectrum-health-systems/outpost31
// Copyright (c) A Pretty Cool Program. All rights reserved.
// Licensed under the Apache 2.0 license.
// -----------------------------------------------------------------------------
// u250904_code
// u250904_documentation
// =============================================================================

namespace Outpost31.Core.Avatar
{
    public class AvatarScriptParameter
    {
        public string Original { get; set; }

        /// <summary>Verify if a Script Parameter was sent from Avatar.</summary>
        /// <param name="origParam">The original Script Parameter sent from Avatar.</param>
        /// <returns>A string indicating if an Script Parameter was sent or not.</returns>
        public static string VerifyExistence(string origParam) =>
            string.IsNullOrWhiteSpace(origParam)
                ? $"The sent script parameter ('{origParam}') does not exist."
                : $"The sent script parameter ('{origParam}') does exist.";
    }
}