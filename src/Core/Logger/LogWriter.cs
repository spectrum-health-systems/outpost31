using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outpost31.Core.Logger
{
    internal class LogWriter
    {
        internal static void ToLocal(string path, string content)
        {
            File.WriteAllText(path, content);
        }
    }
}
