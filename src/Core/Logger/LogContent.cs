/* u250825_code
 * u250825_documentation
 */

using System;

namespace Outpost31.Core.Logger
{
    /// <summary>Generates a formatted log entry consisting of a log header and log body.</summary>
    /// <remarks>
    ///     <include file='AppData/XmlDoc/Core.Logger.xml' path='TngnOpto/Class[@name="LogContent"]/ClassDescription/*'/>
    /// </remarks>
    internal class LogContent
    {
        internal static string Basic(string logType, string logBody)
        {
            return $"{LogHeader.Basic(logType)}" +
                   Environment.NewLine +
                   $"{LogBody.Basic(logBody)}";
        }
    }
}
