using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outpost31.Core.Logger
{
    internal class LogFooter
    {
        /// <summary>Generates a basic log header.</summary>
        /// <param name="logType">The type of log to generate.</param>
        /// <returns>A string containing a basic log header.</returns>
        internal static string Basic(string avtrSys, string logType)
        {
            string currentDateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            var footer = File.ReadAllText($@"C:\Tingen_Data\WebService\{avtrSys}\App\Blueprint\Log\basic-log.footer");

            return footer.Replace("~LOG~TYPE~", logType)
                         .Replace("~CURRENT~DATE~TIME~", currentDateTime);
        }

        internal static string Detailed(string avtrSys, string logName, string exeAsmName, string fromPath, string fromMethod, string fromLine, string code = "---")
        {
            string currentDateTime = DateTime.Now.ToString("MM/dd/yyyy HH:mm:ss");

            var footer = File.ReadAllText($@"C:\Tingen_Data\WebService\{avtrSys}\App\Blueprint\Log\detailed-log.footer");

            return footer.Replace("~ASSEMBLY~", exeAsmName)
                         .Replace("~CLASS~", fromPath)
                         .Replace("~METHOD~", fromMethod)
                         .Replace("~LINE~", fromLine)
                         .Replace("~CODE~", code);
        }
    }
}
