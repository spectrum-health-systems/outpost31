// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                 Core.Service.SvcEnvironment.cs

// u250409_code
// u250409_documentation

// -DEPRECIATED- Class no longer used.

using Outpost31.Core.Runtime;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Service
{
    public partial class SvcEnvironment
    {
        /* Class properties are defined in the SystemCode.Properties.cs partial class. */

        /////// <summary>Builds a new AvatarData data structure.</summary>
        /////// <param name="sentOptObj">The SentOptionObject data structure sent from Avatar.</param>
        /////// <param name="sentScriptParam">The SentScriptParameter sent from Avatar.</param>
        /////// <returns>All of the data/information Tingen needs in order to do work.</returns>
        ////public static string Get(string sysCodeFilePath)
        ////{
        ////    /* Trace Logs won't work here. */

        ////    string sysCodeFile = sysCodeFilePath;
        ////    string sysCode     = DuFile.ReadAndVerifyLocal(sysCodeFile, cat_ValidEnvironments());

        ////    if (sysCode.Contains("The contents of are not valid.")) // test
        ////    {
        ////        // Log this.
        ////        Spin.DownImmediately();
        ////    }

        ////    //#DEVNOTE# Test to make sure this works if the contents are not valid.
        ////    return sysCode;
        ////}
    }
}
