using Newtonsoft.Json;
using System.Text.Json.Serialization;

namespace FlutterwaveCheckout.Web.Models
{
    public class PaymentLinkRequest
    {
        [JsonPropertyName("tx_ref")]
        public string tx_ref { get; set; } = $"{DateTime.Now.ToString("yyMMddhhmmss")}{DateTime.Now.Millisecond}";

        [JsonPropertyName("amount")]
        public decimal amount { get; set; }

        [JsonPropertyName("currency")]
        public string currency { get; set; } = "NGN";

        [JsonPropertyName("redirect_url")]
        public string redirect_url { get; set; }

        [JsonPropertyName("customer")]
        public Customer customer { get; set; }

        [JsonPropertyName("meta")]
        public MetaData meta { get; set; }

        [JsonPropertyName("customizations")]
        public Customization customizations { get; set; }

        [JsonPropertyName("subaccounts")]
        public List<SubAccount> subaccounts { get; set; } = new List<SubAccount>();

        [JsonPropertyName("session_duration")]
        public int? session_duration {  get; set; }//allows you to set the session in minutes with a maximum value of 1440 minutes (24hrs)
    }
}
