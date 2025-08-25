/* u250825_code
 * u250825_documentation
 */

using System.IO;
using System.Text.Json;

namespace Outpost31.Core.Du
{
    internal static class DuJson
    {
        internal static void ExportToFile<JsonObject>(JsonObject jsonObject, string filePath)
        {
            var jsonFormat = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var fileContent = JsonSerializer.Serialize(jsonObject, jsonFormat);

            //File.Create(filePath).Close(); // Need?

            File.WriteAllText(filePath, fileContent);
        }

        internal static JsonObject ImportFromFile<JsonObject>(string filePath)
        {
            var fileContents = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<JsonObject>(fileContents);
        }
    }
}