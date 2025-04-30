// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                           Core.Service.Spin.cs

// u250430_code
// u250430_documentation

using System;
using System.Reflection;

using Outpost31.Core.Session;

namespace Outpost31.Core.Service
{
    /// <summary>Startup/shutdown logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/ClassDescription/*'/>
    public class Spin
    {
        /// <summary>The executing Assembly name.</summary>
        /// <remarks>A required component for writing log files, defined here so it can be used throughout the class.</remarks>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Spin up a new Tingen Web Service session.</summary>
        /// <param name="tngnSession">The (empty) Tingen Web Service session object.</param>
        /// <param name="tngnVersion">The Tingen Web Service current version.</param>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/Up/*'/>
        public static void Up(TngnWbsvSession tngnSession)
        {
            Module.Admin.Status.Current(tngnSession);
            


            //Utility.DataExport.ConfigSummary(TngnConfig.ConfigSummary(tngnSession.TngnConfig), tngnSession.TngnConfig.TngnDataPath);
        }

        /// <summary>Spin down the Tingen Web Service.</summary>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="Spin"]/Down/*'/>
        public static void Down()
        {
            // Gracefully end a Tingen Web Service session.
        }

        public static void DownImmediately()
        {
            Environment.Exit(1);
        }
    }
}