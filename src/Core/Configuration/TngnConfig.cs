// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                               Core.Configuration.TngnConfig.cs

// u250409_code
// u250409_documentation

using System;

using Outpost31.Core.Runtime;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Configuration
{
    /// <summary>Runtime setting logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/ClassDescription/*'/>
    public partial class TngnConfig
    {
        /// <summary>Load the runtime settings for the Tingen Web Service.</summary>
        /// <param name="tngnVersion">The Tingen Web Service version</param>
        /// <returns>Runtime settings for the Tingen Web Service.</returns>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnConfiguration"]/Load/*'/>
        public static TngnConfig New(string tngnVersion)
        {
            RuntimeSettings runtimeSetting = RuntimeSettings.New();

            return new TngnConfig()
            {
                TngnVersion    = tngnVersion,
                TngnBuild      = runtimeSetting.TngnBuild,
               // TngnSystemCode = DuFile.ReadAndVerifyLocal(runtimeSetting.SystemCode, cat_ValidSystemCodes()),
             //   TngnMode       = DuFile.ReadAndVerifyLocal(runtimeSetting.TngnMode, cat_ValidTngnModes()),
                TngnHostName   = Environment.MachineName,
                TngnDataPath   = DuFile.ReadLocal(runtimeSetting.TngnDataPath),
                CurrentDate    = runtimeSetting.DateStamp,
                CurrentTime    = runtimeSetting.TimeStamp
            };
        }
    }
}