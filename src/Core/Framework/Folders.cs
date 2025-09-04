using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outpost31.Core.Framework
{
    public class Folders
    {
        public string Www { get; set; }
        public string Data { get; set; }
        public string Session { get; set; }

        public static Folders Load(string baseWww, string baseData, string sessionDate)
        {
            return new Folders
            {
                Www     = baseWww,
                Data    = baseData,
                Session = $@"{baseData}\Session\{sessionDate}"
            };
        }
    } 
}
