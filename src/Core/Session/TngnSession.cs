//  ██████  ██  ██ ██████ █████ ██████ █████  ██████   ██████  ███ 
//  ██  ██  ██  ██   ██   █████ ██  ██ ██████   ██        ███   ██ 
//  ██████  ██████   ██   ██    ██████  █████   ██     ██████   ██ 
//                                     Core.Session.TngnSession.cs
//                           Logic for Tingen Web Service sessions

// u250404_code
// u250404_documentation

using Outpost31.Core.Runtime;

namespace Outpost31.Core.Session
{
    /// <summary> Session logic for the Tingen Web Service.</summary>
    /// <include file='AppData/XmlDoc/Core.Session.xml' path='Core.Session/Class[@name="TngnSession"]/ClassDescription/*'/>
    public partial class TngnSession
    {
        /// <summary> The runtime settings for the current session.</summary>
        public TngnConfiguration TngnConfig { get; set; }

    }
}
