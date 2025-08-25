using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outpost31.Core.Logger;

namespace Outpost31.Module.Development
{
    public class Reset
    {
        public static void ErrorTemplate(string avtrSys)
        {
            LogEvent.Primeval("UAT", $"Tre");
            Outpost31.Core.Blueprint.Error.CreateTemplate(avtrSys);
        }

    }
}
