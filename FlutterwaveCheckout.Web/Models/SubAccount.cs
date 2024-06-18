using System.Text.Json.Serialization;

namespace FlutterwaveCheckout.Web.Models
{
    public class SubAccount
    {
        [JsonPropertyName("id")]
        public string Id { get; set; }

        [JsonPropertyName("transaction_split_ratio")]
        public int SplitRatio { get; set; }

        [JsonPropertyName("transaction_charge_type")]
        public string ChargeType { get; set; }//"flat"

        [JsonPropertyName("transaction_charge")]
        public string Charge { get; set; }
        //id: "RS_D87A9EE339AE28BFA2AE86041C6DE70E",
        //  transaction_split_ratio: 2,
        //  transaction_charge_type: "flat",
        //  transaction_charge: 100,
    }
}
