using System.Text.Json.Serialization;

namespace PaystackWebCheckout.Web.Models.PayStackModels
{
    public class PayStackCustomerVerification
    {
        [JsonPropertyName("id")]
        public long Id { get; set; }

        [JsonPropertyName("first_name")]
        public string FirstName { get; set; }

        [JsonPropertyName("last_name")]
        public string LastName { get; set; }

        [JsonPropertyName("email")]
        public string Email { get; set; }

        [JsonPropertyName("customer_code")]
        public string CustomerCode { get; set; }

        [JsonPropertyName("phone")]
        public string Phone { get; set; }

        [JsonPropertyName("metadata")]
        public object MetaData { get; set; }

        [JsonPropertyName("risk_action")]
        public string RiskAction { get; set; }

        [JsonPropertyName("international_format_phone")]
        public string InternationalFormatPhone { get; set; }
    }
}
