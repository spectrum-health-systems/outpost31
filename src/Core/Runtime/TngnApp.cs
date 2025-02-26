// u250225_code
// u250226_documentation

using System.Reflection;

using Outpost31.Core.Catalog.Path;

namespace Outpost31.Core.Runtime
{
    /// <summary>Runtime logic.</summary>
    /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnApp"]/*'/>
    public static class TngnApp
    {
        /// <summary>The executing Assembly name.</summary>
        /// <remarks>A required component for writing log files, defined here so it can be used throughout the class.</remarks>
        public static string ExeAsm { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        /// <summary>Startup processes.</summary>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnApp"]/Startup/*'/>
        public static void Startup()
        {
           
        }

        /// <summary>Shutdown processes.</summary>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnApp"]/Shutdown/*'/>
        public static void Shutdown()
        {
        }

        /// <summary>Get the Tingen mode.</summary>
        /// <include file='AppData/XmlDoc/Core.Runtime.xml' path='Core.Runtime/Class[@name="TngnApp"]/GetTngnMode/*'/>
        public static string GetTngnMode()
        {
            return "";
        }
     }
}