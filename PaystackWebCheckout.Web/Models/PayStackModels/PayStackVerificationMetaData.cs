using System.Text.Json.Serialization;

namespace PaystackWebCheckout.Web.Models.PayStackModels
{
    public class PayStackVerificationMetaData
    {
        [JsonPropertyName("referrer")]
        public string Referrer { get; set; }
    }
}
