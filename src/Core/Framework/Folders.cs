using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Outpost31.Core.Framework
{
    public class Folders
    {
        public string Archive { get; set; }
        public string Blueprint { get; set; }
        public string Configuration { get; set; }
        public string Export { get; set; }
        public string Import { get; set; }
        public string Session { get; set; }

        public static Folders Load(string baseFolder, string avatarUser, string date, string time)
        {
            return new Folders
            {
                Archive       = $@"{baseFolder}\Archive",
                Blueprint     = $@"{baseFolder}\AppData\Blueprint",
                Configuration = $@"{baseFolder}\Config",
                Export        = $@"{baseFolder}\Export",
                Import        = $@"{baseFolder}\Import",
                Session       = $@"{baseFolder}\Session\{date}\{avatarUser}\{time}"
            };
        }
    }
}
