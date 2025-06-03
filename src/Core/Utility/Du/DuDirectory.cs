/* Du
 * ██████╗ ██╗   ██╗
 * ██╔══██╗██║   ██║
 * ██║  ██║██║   ██║
 * ██║  ██║██║   ██║
 * ██████╔╝╚██████╔╝
 * ╚═════╝  ╚═════╝
 *     Directory.cs

/* u250603_code
 * u250603_documentation
 */

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
    }
}