// u250225_code
// u250225_documentation

using System.Collections.Generic;

namespace Outpost31.Core.Catalog.Path
{
    /// <summary>The entry point for the Tingen web service.</summary>
    /// <include file='AppData/XmlDocumentation/Core/Catalog.xml' path='Catalog/Class[@name="Files"]/*'/>
    internal static class Files
    {
        /// <summary>Returns a list of required directories.</summary>
        /// <include file='AppData/XmlDocumentation/Core/Catalog.xml' path='Catalog/Class[@name="Files"]/Required/*'/>
        internal static Dictionary<string, string> Required()
        {
            return new Dictionary<string, string>
            {
                { "TngnSystemCode", @"./AppData/Runtime/system.code" }
            };
        }
    }
}