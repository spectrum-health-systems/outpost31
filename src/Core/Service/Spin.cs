// ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███
// ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██
// ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██
//                                           Core.Service.Spin.cs

// u250501_code
// u250501_documentation

using System;
using System.Reflection;
using Outpost31.Core.Logger;
using Outpost31.Core.Session;
using ScriptLinkStandard.Objects;

namespace Outpost31.Core.Service
{
    /// <summary>Startup/shutdown logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Service.xml' path='Core.Service/Class[@name="Spin"]/ClassDescription/*'/>
    public class Spin
    {
        /// <summary>The executing Assembly name.</summary>
        /// <remarks>A required component for writing log files, defined here so it can be used throughout the class.</remarks>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Spin up a new instance of the Tingen Web Service.</summary>
        /// <param name="sentOptObj"></param>
        /// <param name="sentScriptParam"></param>
        /// <returns></returns>
        public static void Up(TngnWbsvSession tngnWbsvSession, OptionObject2015 sentOptObj, string sentScriptParam, string tngnWbsvVersion, string tngnWbsvEnvironment)
        {
            LogEvent.Debuggler(tngnWbsvEnvironment, $"[SPINNING UP]");

            tngnWbsvSession = TngnWbsvSession.New(sentOptObj, sentScriptParam, tngnWbsvVersion, tngnWbsvEnvironment);

            LogEvent.Debuggler(tngnWbsvEnvironment, $"[SPUN UP] {tngnWbsvSession.SentScriptParam}");
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