using System.Text.Json;
using System.Text.Json.Serialization;

namespace OnlinnePizza.Models
{
    public class Pizza
    {
       [ JsonPropertyName("id")]
        public int Pizza_id { get; set; }
        [JsonPropertyName("name")]
        public string Pizza_name { get; set; }
        [JsonPropertyName("image")]
        public string Pizza_image { get; set; }

        public override string ToString()
        {
           return JsonSerializer.Serialize<Pizza>(this);
        }
    }
}
