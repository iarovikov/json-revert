using System.IO;
using System.Linq;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace JsonRevert.WebAPI.BusinessLogic
{
    public class JsonReverter : IJsonReverter
    {
        public string RevertJson(string jsonToRevert)
        {
            JObject jObject = JObject.Parse(jsonToRevert);
            
            // Revert properties.
            var newProp = jObject.Properties().Reverse().ToList();
            var reverted = new JObject();
            // Create new reverted object with reverted properties.
            foreach (var property in newProp)
            {
                reverted.Add(property);
            }
            
            // Removing quotes in keys name
            var serializer = JsonSerializer.Create();
            using (var stringWriter = new StringWriter())
            {
                using (var jsonWriter = new JsonTextWriter(stringWriter))
                {
                    // Removing quotes
                    jsonWriter.QuoteName = false;
                    jsonWriter.Formatting = Formatting.Indented;

                    serializer.Serialize(jsonWriter, reverted);
                    return stringWriter.ToString();
                }
            }
        }
    }
}