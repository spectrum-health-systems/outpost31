/* u250825_code
 * u250825_documentation
 */

namespace Outpost31.Core.Logger
{
    internal class LogPath
    {
        internal static string AppLogPath(string avtrSys, string logName, string logType)
        {
            return $@"C:\Tingen_Data\WebService\{avtrSys}\App\Log\{logType}\{logName}.{logType.ToLower()}";
        }
    }
}