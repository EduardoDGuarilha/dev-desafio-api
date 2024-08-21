using System.Text.Json.Serialization;

namespace Contracts.Models.Dto
{
    public class InfoDto
    {
        [JsonPropertyName("count")]
        public int Count { get; set; }

        [JsonPropertyName("pages")]
        public int Pages { get; set; }

        [JsonPropertyName("next")]
        public string? Next { get; set; }

        [JsonPropertyName("prev")]
        public string? Previous { get; set; }
    }
}
