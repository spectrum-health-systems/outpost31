/* u250825_code
 * u250825_documentation
 */

using System.Reflection;

namespace Outpost31.Module.Admin
{
    public class Develop
    {
        /// <summary>The executing assembly name.</summary>
        /// <remarks>
        ///     <include file='/AppData/XmlDoc/Common.xml' path='TngnOpto/Class[@name="Common"]/ExeAsmName/*'/>
        /// </remarks>
        public static string ExeAsmName { get; set; } = Assembly.GetExecutingAssembly().GetName().Name;

    }
}