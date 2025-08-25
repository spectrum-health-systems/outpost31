using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Outpost31.Core.Utility.Du;

namespace Outpost31.Core.Blueprint
{
    internal class Error
    {
        public string Title { get; set; }
        public string Message { get; set; }
        public string Code { get; set; }

        internal static Error Load(string error)
        {
            return DuJson.ImportFromFile<Error>(error);
        }

        internal static void CreateTemplate(string avtrSys)
        {
            var error = new Error
            {
                Title = "Error title",
                Message = "Error message",
                Code = "Error code"
            };

            DuJson.ExportToFile<Error>(error, $@"C:\Tingen_Data\WebService\{avtrSys}\App\Blueprint\Error\Template.error");
        }
    }
}
