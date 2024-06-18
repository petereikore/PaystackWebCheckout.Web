using System.Text.Json.Serialization;

namespace PaystackWebCheckout.Web.Models.PayStackModels
{
    public class PayStackVerificationResponse
    {
        [JsonPropertyName("status")]
        public bool Status { get; set; }

        [JsonPropertyName("message")]
        public string Message { get; set; }

        [JsonPropertyName("data")]
        public PaystackVerificationData Data { get; set; }
    }
}
