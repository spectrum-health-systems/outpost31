// ██████╗ ██╗   ██╗
// ██╔══██╗██║   ██║
// ██║  ██║██║   ██║
// ██║  ██║██║   ██║
// ██████╔╝╚██████╔╝
// ╚═════╝  ╚═════╝
// Du.Json.cs

// u250430_code
// u250430_documentation

using System.IO;
using System.Text.Json;

namespace Outpost31.Core.Utility.Du
{
    public static class DuJson
    {
        /// <summary>Export JSON data to an external file.</summary>
        /// <typeparam name="JsonObject">The JSON object type.</typeparam>
        /// <param name="jsonObject">The JSON object.</param>
        /// <param name="filePath">The export file path.</param>
        /// <param name="formatJson">Determines if the JSON data is formatted.</param>
        /// <remarks>
        ///     <para>
        ///         <example>
        ///             To export a nicely-formatted JSON object:
        ///             <code>
        ///                 TheObject theObject = new TheObject();
        ///                 DuJson.ExportToLocalFile&lt;TheObject&gt;(theObject, "/Path/To/Export/File");
        ///             </code>
        ///         </example>
        ///         <example>
        ///             To export an unformatted JSON object:
        ///             <code>
        ///                 TheObject theObject = new TheObject();
        ///                 DuJson.ExportToLocalFile&lt;TheObject&gt;(theObject, "/Path/To/Export/File", false);
        ///             </code>
        ///         </example>
        ///     </para>
        /// </remarks>
        public static void ExportToLocalFile<JsonObject>(JsonObject jsonObject, string filePath, bool formatJson = true)
        {
            JsonSerializerOptions jsonFormat = new JsonSerializerOptions
            {
                WriteIndented = formatJson
            };

            string fileContent = JsonSerializer.Serialize(jsonObject, jsonFormat);

            File.WriteAllText(filePath, fileContent);
        }

        /// <summary>Import JSON data from an external file. [250108]</summary>
        /// <typeparam name="JsonObject">The JSON object type.</typeparam>
        /// <param name="filePath">The import file path.</param>
        /// <remarks>
        ///     <para>
        ///         <example>
        ///             To import a JSON object from a local file:
        ///             <code>
        ///                 TheObject theObject = DuJson.ImportFromLocalFile&lt;TheObject&gt;("/Path/To/Import/File");
        ///             </code>
        ///         </example>
        ///     </para>
        /// </remarks>
        /// <returns>The contents of the file as a JSON object.</returns>
        public static JsonObject ImportFromLocalFile<JsonObject>(string filePath)
        {
            var fileContents = File.ReadAllText(filePath);

            return JsonSerializer.Deserialize<JsonObject>(fileContents);
        }
    }
}
