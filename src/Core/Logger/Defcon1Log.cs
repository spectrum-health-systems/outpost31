// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                         Core.Logger.Defcon1.cs

// u250414_code
// u250414_documentation

using System;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Logger
{
    /// <summary>If you're writing a Defcon1 file, you're having a bad time.</summary>
    public class Defcon1Log
    {
        public static void Create(string defconPath, string message)
        {
            /* Trace/Primeval Logs won't work here. */

            var filePath = $@"{defconPath}\{DateTime.Now:yyMMddHHmmssfffffff}.defcon1";

            DuFile.WriteLocal(filePath, message);
        }
    }
}
