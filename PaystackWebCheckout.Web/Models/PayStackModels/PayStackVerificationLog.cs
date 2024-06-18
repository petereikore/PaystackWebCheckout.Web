using System.Text.Json.Serialization;

namespace PaystackWebCheckout.Web.Models.PayStackModels
{
    public class PayStackVerificationLog
    {
        [JsonPropertyName("start_time")]
        public long StartTime { get; set; }

        [JsonPropertyName("time_spent")]
        public long TimeSpent { get; set; }

        [JsonPropertyName("attempts")]
        public int Attempts { get; set; }

        [JsonPropertyName("authentication")]
        public string Authentication { get; set; }

        [JsonPropertyName("errors")]
        public string Errors { get; set; }

        [JsonPropertyName("success")]
        public bool Success { get; set; }

        [JsonPropertyName("mobile")]
        public bool Mobile { get; set; }
    }
}
