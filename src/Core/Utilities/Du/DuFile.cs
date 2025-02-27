// ██████╗ ██╗   ██╗   ███████╗██╗██╗     ███████╗
// ██╔══██╗██║   ██║   ██╔════╝██║██║     ██╔════╝
// ██║  ██║██║   ██║   █████╗  ██║██║     █████╗  
// ██║  ██║██║   ██║   ██╔══╝  ██║██║     ██╔══╝  
// ██████╔╝╚██████╔╝██╗██║     ██║███████╗███████╗
// ╚═════╝  ╚═════╝ ╚═╝╚═╝     ╚═╝╚══════╝╚══════╝
//                             Do stuff with files                                              
// u250227_code
// u250227_documentation            

using System.Collections.Generic;

namespace Outpost31.Core.Utilities.Du
{
    /// <summary>Logic related to files.</summary>
    public static class DuFile
    {
        /// <summary>Returns the contents or status of a file. </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <returns>The content or status of the file.</returns>
        /// <remarks>
        ///   <para>
        ///   </para>
        /// </remarks>
        public  static string ReturnContent(string filePath)
        {
            if (!System.IO.File.Exists(filePath))
            {
                var fileContent = System.IO.File.ReadAllText(filePath);

                return fileContent == null
                    ? "Empty"
                    : fileContent;
            }
            else
            {
                return "Non-existent";
            }
        }

        /// <summary>Returns the contents (if valid) or status of a file. </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <param name="validContent">A list of valid content.</param>
        /// <returns>The verified content or status of the file.</returns>
        /// <remarks>
        ///   <para>
        ///   </para>
        /// </remarks>
        public static string ReturnVerifiedContent(string filePath, List<string> validContent)
        {
            if (!System.IO.File.Exists(filePath))
            {
                var fileContent = System.IO.File.ReadAllText(filePath);

                return fileContent == null
                    ? "Empty"
                    : validContent.Contains(fileContent)
                        ? fileContent
                        : "Invalid";
            }
            else
            {
                return "Non-existent";
            }
        }
    }
}