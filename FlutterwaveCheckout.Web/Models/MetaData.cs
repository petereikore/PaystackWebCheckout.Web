using System.Text.Json.Serialization;

namespace FlutterwaveCheckout.Web.Models
{
    public class MetaData
    {
        [JsonPropertyName("consumer_id")]
        public int CustomerId { get; set; }

        [JsonPropertyName("consumer_mac")]
        public string CustomerMacAddress { get; set; }
    }
}
