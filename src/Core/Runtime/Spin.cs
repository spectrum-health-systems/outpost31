//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███ 
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██ 
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██ 

// u250404_code
// u250404_documentation

// Ignore Spelling: tngn

using System.Reflection;

using Outpost31.Core.Session;
using Outpost31.Core.Utility.Du;

using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Runtime
{
    /// <summary>Startup/shutdown logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/ClassDescription/*'/>
    public static class Spin
    {
        /// <summary>The executing Assembly name.</summary>
        /// <remarks>A required component for writing log files, defined here so it can be used throughout the class.</remarks>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Spin up a new Tingen Web Service session.</summary>
        /// <param name="tngnSession">The (empty) Tingen Web Service session object.</param>
        /// <param name="tngnVersion">The Tingen Web Service current version.</param>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/Up/*'/>
        public static void Up(TngnSession tngnSession, string tngnVersion, OptionObject2015 sentOptionObject, string sentScriptParameter)
        {
            tngnSession.TngnConfig = TngnConfiguration.Load(tngnVersion);

            Logger.LogEvent.Primeval(tngnSession.TngnConfig.TngnDirectories["PrimevalLog"], ExeAsm, "Tingen primeval log");



            //var wpath = $@"{tngnSession.TngnConfig.TngnHostDataPath}/{tngnSession.TngnConfig.TngnSystemCode}/Debugging/Runtime.config";




            //DuFile.WriteLocal(wpath, tngnSession.TngnConfig.ConfigurationSummary);
            
            //Utility.DataExport.RteConfigToFile(tngnSession.RuntimeConfig.RuntimeSummary);



            //bool validRuntimeConfig = TngnConfiguration.AreValid(tngnSession.RuntimeConfig);

            //if (validRuntimeConfig)
            //{
            //    Utility.DataExport.RteConfigToFile(tngnSession.RuntimeConfig.RuntimeSummary);

            //}
            //else
            //{
            //    // Log an error message.
            //    // Maybe throw an OptObj error?
            //}
        }

        /// <summary>Spin down the Tingen Web Service.</summary>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/Down/*'/>
        public static void Down()
        {
            // Gracefully end a Tingen Web Service session.
        }
    }
}