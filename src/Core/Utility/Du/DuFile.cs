// ██████╗ ██╗   ██╗
// ██╔══██╗██║   ██║
// ██║  ██║██║   ██║
// ██║  ██║██║   ██║
// ██████╔╝╚██████╔╝
// ╚═════╝  ╚═════╝
// Du.File.cs                                          

// u250430_code
// u250430_documentation
using System.Collections.Generic;

namespace Outpost31.Core.Utility.Du
{
    /// <summary>Logic related to files input/output.</summary>
    public static class DuFile
    {
        /// <summary>Returns the contents or status of a file. </summary>
        /// <param name="filePath">The path to the file.</param>
        /// <remarks>
        ///     <para>
        ///         If the file exists <i>and has content</i>, that content is returned.<br/>
        ///         <br/>
        ///         If the file <i>does not exist</i>, or exists <i>but is empty</i>, an error message is returned.
        ///     </para>
        /// </remarks>
        /// <returns>The content or status of the file.</returns>
        public static string ReadLocal(string filePath)
        {
            if (System.IO.File.Exists(filePath))
            {
                var fileContent = System.IO.File.ReadAllText(filePath);

                return fileContent == null
                    ? $@"File {filePath} does not contain data."
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
        /// <remarks>
        ///     <para>
        ///         GetContent() returns the contents or status of the file.<br/>
        ///         <br/>
        ///         If the file contains data, that data is checked against the list of valid content.
        ///     </para>
        /// </remarks>
        /// <returns>The verified content or status of the file.</returns>
        public static string ReadAndVerifyLocal(string filePath, List<string> validContent)
        {
            var fileContent = ReadLocal(filePath);

            if (fileContent.Contains("does not exist") || fileContent.Contains("does not contain data"))
            {
                return fileContent;
            }
            else
            {
                return validContent.Contains(fileContent)
                    ? fileContent
                    : $@"The contents of {filePath} are not valid.";
            }
        }

        public static void WriteLocal(string filePath, string content)
        {
            System.IO.File.WriteAllText(filePath, content);
        }

        public static void WriteLocal(string filePath, string content, bool overwrite)
        {
            if (overwrite)
            {
                if (System.IO.File.Exists(filePath))
                {
                    // Delete the file if it exists.
                    System.IO.File.Delete(filePath);
                }
            }

            System.IO.File.WriteAllText(filePath, content);
        }

    }
}