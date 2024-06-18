using System.Text.Json.Serialization;

namespace FlutterwaveCheckout.Web.Models
{
    public class Customization
    {
        [JsonPropertyName("title")]
        public string Title { get; set; }

        [JsonPropertyName("description")]
        public string Description { get; set; }

        [JsonPropertyName("logo")]
        public string Logo { get; set; }
    }
}
