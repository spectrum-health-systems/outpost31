using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outpost31.Core.Logger
{
    internal class LogPathBuilder
    {
        /// <summary>Generates the base path for a log.</summary>
        /// <param name="avtrSys">The Avatar environment that the Tingen Web Service has interfaced with.</param>
        /// <param name="logType">The type of log to generate.</param>
        /// <returns>The base path for the log.</returns>
        /// <value>Example: "C:\Tingen_Data\WebService\UAT\Logs\Debug"</value>
        internal static string AppLogPath(string avtrSys, string logName, string logType)
        {
            return $@"C:\Tingen_Data\WebService\{avtrSys}\App\Log\{logType}\{logName}.{logType.ToLower()}";
        }
    }
}
