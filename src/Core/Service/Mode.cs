//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                            Core.Service.Mode.cs

// u250409_code
// u250409_documentation

using Outpost31.Core.Runtime;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Service
{
    public partial class Mode
    {
        /// <summary>Builds a new AvatarData data structure.</summary>
        /// <param name="sentOptObj">The SentOptionObject data structure sent from Avatar.</param>
        /// <param name="sentScriptParam">The SentScriptParameter sent from Avatar.</param>
        /// <returns>All of the data/information Tingen needs in order to do work.</returns>
        public static string Get(string tngnModeFilePath)
        {
            /* Trace Logs won't work here. */

            string sysCodeFile = tngnModeFilePath;
            string sysCode     = DuFile.ReadAndVerifyLocal(sysCodeFile, cat_ValidTngnModes());

            if (sysCode.Contains("The contents of are not valid.")) // test
            {
                // Log this.
                SpinDown.ExitImmediately();
            }

            //#DEVNOTE# Test to make sure this works if the contents are not valid.
            return sysCode;
        }
    }
}