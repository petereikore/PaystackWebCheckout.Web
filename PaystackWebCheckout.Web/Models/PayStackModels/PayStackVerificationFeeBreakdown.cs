using System.Text.Json.Serialization;

namespace PaystackWebCheckout.Web.Models.PayStackModels
{
    public class PayStackVerificationFeeBreakdown
    {
        [JsonPropertyName("amount")]
        public decimal Amount { get; set; }

        [JsonPropertyName("formula")]
        public object Formula { get; set; }

        [JsonPropertyName("type")]
        public string Type { get; set; }
    }
}
