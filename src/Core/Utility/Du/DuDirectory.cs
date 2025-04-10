// ██████╗ ██╗   ██╗
// ██╔══██╗██║   ██║
// ██║  ██║██║   ██║
// ██║  ██║██║   ██║
// ██████╔╝╚██████╔╝
// ╚═════╝  ╚═════╝
// Du.Directory.cs

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