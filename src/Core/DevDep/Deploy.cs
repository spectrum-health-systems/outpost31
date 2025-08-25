/* u250825_code
 * u250825_documentation
 */

using System.IO;

namespace Outpost31.Core.DevDep
{
    public class Deploy
    {
        public static void InitializeTngnWsvc(string avtrSys)
        {
            RefreshBlueprints(avtrSys);
        }

        public static void RefreshBlueprints(string avtrSys)
        {
            var blueprintPath = $@"C:\Tingen_Data\WebService\{avtrSys}\App\Blueprint";

            if (Directory.Exists(blueprintPath))
            {
                Directory.Delete(blueprintPath, true);
            }

            Directory.CreateDirectory(blueprintPath);

            CopyDirectory($@"C:\Tingen_www\WebService\{avtrSys}\bin\AppData\Blueprint", blueprintPath);
        }

        /// TODO move to a utility class
        internal static void CopyDirectory(string sourceDir, string destinationDir)
        {
            // Ensure the destination directory exists
            Directory.CreateDirectory(destinationDir);

            // Copy all files
            foreach (string file in Directory.GetFiles(sourceDir))
            {
                string destFile = Path.Combine(destinationDir, Path.GetFileName(file));
                File.Copy(file, destFile, true); // Overwrite if file exists
            }

            // Recursively copy subdirectories
            foreach (string subDir in Directory.GetDirectories(sourceDir))
            {
                string destSubDir = Path.Combine(destinationDir, Path.GetFileName(subDir));
                CopyDirectory(subDir, destSubDir);
            }
        }
    }
}
