//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███ 
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██ 
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██ 
//                                  Outpost31.Core.Runtime.Spin.cs
//               Startup/shutdown logic for the Tingen Web Service
// u250227_code
// u250227_documentation

using Outpost31.Core.Session;

namespace Outpost31.Core.Runtime
{
    /// <summary>Startup/shutdown logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/Spin/*'/>
    public class Spin
    {
        /// <summary>Spin up a new instance of the Tingen Web Service.</summary>
        /// <param name="tngnSession">The Tingen Web Service session object.</param>
        /// <param name="tngnVersion">The Tingen Web Service version.</param>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/Up/*'/>
        public static void Up(TngnSession tngnSession, string tngnVersion)
        {
            tngnSession.RuntimeSettings = Configuration.RuntimeSettings.Load(tngnVersion);
            bool validRuntimeSettings = Configuration.RuntimeSettings.AreValid(tngnSession.RuntimeSettings);
        }

        /// <summary>Spin down the Tingen Web Service.</summary>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/Down/*'/>
        public static void Down()
        {
        }
    }
}