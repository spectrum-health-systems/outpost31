using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outpost31.Core.Logger
{
    internal class LogBlueprint
    {
        public static string LogHeader()
        {
            return File.ReadAllText(@"C:\Tingen_Data\WebService\UAT\Tinplate\Log\log-header.tinplate");
        }
    }
}
