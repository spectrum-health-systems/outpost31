//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███ 
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██ 
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██ 
//                                            Core.Runtime.Spin.cs
//               Startup/shutdown logic for the Tingen Web Service
// u250311_code
// u250311_documentation

using Outpost31.Core.Session;

using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Runtime
{
    /// <summary>Startup/shutdown logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/Spin/*'/>
    public class Spin
    {
        /// <summary>Spin up a new Tingen Web Service session.</summary>
        /// <param name="tngnSession">The (empty) Tingen Web Service session object.</param>
        /// <param name="tngnVersion">The Tingen Web Service current version.</param>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/Up/*'/>
        public static void Up(TngnSession tngnSession, string tngnVersion, OptionObject2015 sentOptionObject, string sentScriptParameter)
        {
            tngnSession.RuntimeConfig = RuntimeConfiguration.Load(tngnVersion);

            bool validRuntimeConfig = RuntimeConfiguration.AreValid(tngnSession.RuntimeConfig);

            if (validRuntimeConfig)
            {
                Utility.DataExport.RteConfigToFile(tngnSession.RuntimeConfig.RuntimeSummary);

            }
            else
            {
                // Log an error message.
                // Maybe throw an OptObj error?
            }
        }

        /// <summary>Spin down the Tingen Web Service.</summary>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/Down/*'/>
        public static void Down()
        {
            // Gracefully end a Tingen Web Service session.
        }
    }
}