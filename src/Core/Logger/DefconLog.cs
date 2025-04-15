// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                          Core.Logger.Defcon.cs

// u250414_code
// u250414_documentation

using System;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Logger
{
    /// <summary>If you're writing a Defcon file, you're probably having a bad time.</summary>
    public class DefconLog
    {
        public static void CreateDefcon1(string pathPrefix, string message)
        {
            /* Trace/Defcon1 Logs won't work here. */

            var fullPath = $@"{pathPrefix}\{DateTime.Now:yyMMddHHmmssfffffff}.defcon1";

            DuFile.WriteLocal(fullPath, message);
        }
    }
}
