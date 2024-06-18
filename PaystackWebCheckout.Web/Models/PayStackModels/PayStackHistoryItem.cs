using System.Text.Json.Serialization;

namespace PaystackWebCheckout.Web.Models.PayStackModels
{
    public class PayStackHistoryItem
    {
        [JsonPropertyName("type")]
        public string Type { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("time")]
        public int Time { get; set; }
    }
}
