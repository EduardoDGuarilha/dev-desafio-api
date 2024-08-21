using System.Text.Json;
using System.Text.Json.Serialization;

namespace Contracts.Models.Entities
{
    public class Location
    {
        [JsonPropertyName("name")]
        public string Name { get; set; }

        [JsonPropertyName("url")]
        public string Url { get; set; }
    }
}