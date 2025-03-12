//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███ 
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██ 
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██ 
//                                     Core.Session.TngnSession.cs
//                           Logic for Tingen Web Service sessions
// u250311_code
// u250311_documentation

using System.Collections.Generic;
using System;

using Outpost31.Core.Runtime;

namespace Outpost31.Core.Session
{
    /// <summary> Session logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Session.xml' path='Core.Session/Class[@name="TngnSession"]/TngnSession/*'/>
    public class TngnSession
    {
        /// <summary> The runtime settings for the current session.</summary>
        public RuntimeConfiguration RuntimeConfig { get; set; }

    }
}
