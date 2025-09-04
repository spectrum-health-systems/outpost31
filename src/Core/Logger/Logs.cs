using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outpost31.Core.Framework;

namespace Outpost31.Core.Logger
{
    public class Logs
    {
        public int TraceLogLimit { get; set; }

        public static Logs Load(string traceLogLimit)
        {
            return new Logs
            {
                TraceLogLimit = Convert.ToInt32(traceLogLimit)
            };
        }
    }
}
