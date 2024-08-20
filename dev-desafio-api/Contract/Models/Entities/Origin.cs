using System.Text.Json.Serialization;

namespace Contracts.Models.Entities
{
    public class Origin
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}