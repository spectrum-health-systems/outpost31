/* Outpost31.Core.Logger.LogWriter.cs
 * u250616_code
 * u250616_documentation
 */

using System.Collections.Generic;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Logger
{
    public class LogWriter
    {
        /// <summary>Writes log content to a local file.</summary>
        /// <param name="logComponent">A dictionary containing the file path and log content.  The key <c>"FullPath"</c> specifies the full path to
        /// the file,  and the key <c>"LogContent"</c> specifies the content to be written.</param>
        public static void WriteLogToFile(Dictionary<string, string> logComponent)
        {
            DuFile.WriteLocal(logComponent["FullPath"], logComponent["LogContent"]);
        }
    }
}