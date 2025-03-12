// ██████╗ ██╗   ██╗   ███████╗██╗██╗     ███████╗
// ██╔══██╗██║   ██║   ██╔════╝██║██║     ██╔════╝
// ██║  ██║██║   ██║   █████╗  ██║██║     █████╗  
// ██║  ██║██║   ██║   ██╔══╝  ██║██║     ██╔══╝  
// ██████╔╝╚██████╔╝██╗██║     ██║███████╗███████╗
// ╚═════╝  ╚═════╝ ╚═╝╚═╝     ╚═╝╚══════╝╚══════╝
//                             Du stuff with files                                              
// u250311_code
// u250311_documentation

using System.Collections.Generic;

namespace Outpost31.Core.Utility.Du
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
        public static string GetContent(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                var fileContent = System.IO.File.ReadAllText(filePath);

                return fileContent == null
                    ? "Empty"
                    : fileContent;
            }
            else
            {
                return $@"File {filePath} does not exist";
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
        public static string GetVerifiedContent(string filePath, List<string> validContent)
        {
            var fileContent = GetContent(filePath);

            return validContent.Contains(fileContent)
                ? fileContent
                : "Invalid";
        }
    }
}