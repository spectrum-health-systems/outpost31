// u250225_code
// u250225_documentation

using System.IO;

namespace Outpost31.Core.Avatar
{
    /// <summary>Logic for Avatar System Codes.</summary>
    /// <include file='AppData/XmlDocumentation/Core/Avatar.xml' path='Avatar/Class[@name="SystemCode"]/*'/>
    internal static class SystemCode
    {
        /// <summary>Get the Avatar System Code that the Tingen Web Service will use.</summary>
        /// <returns>The Avatar System Code the Tingen Web Service will use.</returns>
        /// <include file='AppData/XmlDocumentation/Core/Avatar.xml' path='Avatar/Class[@name="SystemCode"]/GetSystemCode/*'/>
        internal static string GetSystemCode()
        {
            /* Trace Logs can't go here because the logging infrastructure hasn't been initialized yet, so if you
               * need to create a log file here, use a Primeval Log.
               */

            const string systemCodeFilePath = @"./AppData/Runtime/system.code";
            string systemCode               = "UNKNOWN";

            if (File.Exists(systemCodeFilePath))
            {
                //[?] Test to make sure this works, and the ".ToLower()" doesn't need to be in the if...then statement
                switch (File.ReadAllText(systemCodeFilePath.ToLower()))
                {
                    case "live":
                        systemCode = "LIVE";
                        break;

                    case "uat":
                        systemCode = "UAT";
                        break;
                }
            }

            return systemCode;
        }
    }
}
