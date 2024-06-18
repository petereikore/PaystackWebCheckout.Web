using System.Text.Json.Serialization;

namespace PaystackWebCheckout.Web.Models.PayStackModels
{
    public class PayStackVerificationAuthorization
    {
        [JsonPropertyName("authorization_code")]
        public string AuthorizationCode { get; set; }

        [JsonPropertyName("bin")]
        public string Bin { get; set; }

        [JsonPropertyName("last4")]
        public string Last4 { get; set; }

        [JsonPropertyName("exp_month")]
        public string ExpiryMonth { get; set; }

        [JsonPropertyName("exp_year")]
        public string ExpiryYear { get; set; }

        [JsonPropertyName("channel")]
        public string Channel { get; set; }

        [JsonPropertyName("card_type")]
        public string CardType { get; set; }

        [JsonPropertyName("bank")]
        public string Bank { get; set; }

        [JsonPropertyName("country_code")]
        public string CountryCode { get; set; }

        [JsonPropertyName("brand")]
        public string Brand { get; set; }

        [JsonPropertyName("reusable")]
        public bool Reusable { get; set; }

        [JsonPropertyName("signature")]
        public string Signature { get; set; }

        [JsonPropertyName("account_name")]
        public string AccountName { get; set; }

        [JsonPropertyName("receiver_bank_account_number")]
        public string ReceiverBankAccountNumber { get; set; }

        [JsonPropertyName("receiver_bank")]
        public string ReceiverBank { get; set; }
    }
}
