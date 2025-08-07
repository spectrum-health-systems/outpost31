/* DuDirectory.cs
 * Does stuff with directories.
 * b250625
 * A Pretty Cool Program
 * https://gist.github.com/APrettyCoolProgram/6f8cb8e700fdccc39bf5314aefec8703
 */

using System.IO;

namespace Outpost31.Core.Utility.Du
{
    public class DuDirectory
    {
        public static void ConfirmExists(string path)
        {
            if (!System.IO.Directory.Exists(path))
            {
                System.IO.Directory.CreateDirectory(path);
            }
        }

        /// <summary>Verify a parent directory of a file exists.</summary>
        /// <param name="fullPath">The full path of a file.</param>
        public static void VerifyParent(string fullPath)
        {
            var dirInfo = new DirectoryInfo(fullPath);

            if (!dirInfo.Parent.Exists)
            {
                Directory.CreateDirectory(dirInfo.Parent.ToString());
            }
        }
    }
}