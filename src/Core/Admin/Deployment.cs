/* u250828_code
 * u250828_documentation
 */

using System.IO;
using System.Reflection;

namespace Outpost31.Core.Admin
{
    public class Deployment
    {
        /// <summary>The executing assembly name.</summary>
        /// <remarks>
        ///     <include file='/AppData/XmlDoc/Common.xml' path='TngnOpto/Class[@name="Common"]/ExeAsmName/*'/>
        /// </remarks>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

        public static void InitializeTngnWsvc(string avtrSys)
        {
            ///* For debugging only
            // */
            //LogEvent.Trace(avtrSys, ExeAsmName, $"");

            //var assembly = Assembly.GetExecutingAssembly();
            //var resourceName = "Outpost31.Core.DevDep.framework.folder";

            //Logger.LogEvent.Primeval(avtrSys, $"Regression test: Primeval log");


            ////var resourceName = "MyCompany.MyProduct.framework.folder";

            //string result;


            //using (Stream stream = assembly.GetManifestResourceStream(resourceName))
            //using (StreamReader reader = new StreamReader(stream))
            //{
            //    result = reader.ReadToEnd();
            //}


            //var listr = result.ToList();

            ////var listr = File.ReadAllLines(avtrSys + @"\AppData\TngnWsvc\Blueprint\Framework\framework.folder").ToList();



            //foreach (var folder in listr)
            //{
            //    Directory.CreateDirectory($@"C:\Tingen_Data\WebService\{avtrSys}\AppData\TngnWsvc\Blueprint\Framework\{folder}");
            //}
        }

        /// <summary>Refresh all AppData data/resources.</summary>
        /// <param name="avtrSys"></param>
        public static void RefreshAppData(string avtrSys)
        {
            /* For debugging only
             */
            //LogEvent.Trace(avtrSys, ExeAsmName, $"");

            var targetAppDataPath = $@"C:\Tingen_Data\WebService\{avtrSys}\AppData\";

            if (Directory.Exists(targetAppDataPath))
            {
                Directory.Delete(targetAppDataPath, true);
            }

            Directory.CreateDirectory(targetAppDataPath);

            CopyDirectory($@"C:\Tingen_www\WebService\{avtrSys}\bin\AppData\", targetAppDataPath);
        }

        /// TODO move to a utility class
        internal static void CopyDirectory(string sourceDir, string destinationDir)
        {
            /* For debugging only
             */
            //LogEvent.Trace("", ExeAsmName, $"");

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