using System.Text.Json.Serialization;

namespace FlutterwaveCheckout.Web.Models
{
    public class PaymentLinkResponse
    {
        [JsonPropertyName("status")]
        public string Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public Data Data { get; set; }
    }

    public class Data
    {
        [JsonPropertyName("link")]
        public string Link { get; set; }
    }
}
