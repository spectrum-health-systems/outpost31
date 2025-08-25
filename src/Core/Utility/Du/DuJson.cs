/* DuJson.cs
* Does stuff with JSON data.
* b250801
* A Pretty Cool Program
* https://
*/

using System.IO;
using System.Text.Json;

namespace Outpost31.Core.Utility.Du
{
    /// <summary>Does stuff with JSON data.</summary>
    public static class DuJson
    {
        // [250801]
        /// <summary>Export JSON data to an external file. [250108]</summary>
        /// <typeparam name="JsonObject">The JSON object type.</typeparam>
        /// <param name="jsonObject">The JSON object.</param>
        /// <param name="filePath">The export file path.</param>
        /// <remarks>
        ///  <para>
        ///   <example>
        ///    To export a nicely-formatted JSON object:
        ///    <code>
        ///     TheObject theObject = new TheObject();
        ///     DuJson.ExportToLocalFile&lt;TheObject&gt;(theObject, "/Path/To/Export/File");
        ///    </code>
        ///   </example>
        ///   <example>
        ///    To export an unformatted JSON object:
        ///    <code>
        ///     TheObject theObject = new TheObject();
        ///     DuJson.ExportToLocalFile&lt;TheObject&gt;(theObject, "/Path/To/Export/File", false);
        ///    </code>
        ///   </example>
        ///  </para>
        /// </remarks>
        public static void ExportToFile<JsonObject>(JsonObject jsonObject, string filePath)
        {
            var jsonFormat = new JsonSerializerOptions
            {
                WriteIndented = true
            };

            var fileContent = JsonSerializer.Serialize(jsonObject, jsonFormat);

            File.WriteAllText(filePath, fileContent);
        }

        // [250801]
        /// <summary>Import JSON data from an external file. [250108]</summary>
        /// <typeparam name="JsonObject">The JSON object type.</typeparam>
        /// <param name="filePath">The import file path.</param>
        /// <remarks>
        ///  <para>
        ///   <example>
        ///    To import a JSON object from a local file:
        ///    <code>
        ///      TheObject theObject = DuJson.ImportFromLocalFile&lt;TheObject&gt;("/Path/To/Import/File");
        ///    </code>
        ///   </example>
        ///  </para>
        /// </remarks>
        /// <returns>The contents of the file as a JSON object.</returns>
        public static JsonObject ImportFromFile<JsonObject>(string filePath)
        {
            var fileContents = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<JsonObject>(fileContents);
        }
    }
}