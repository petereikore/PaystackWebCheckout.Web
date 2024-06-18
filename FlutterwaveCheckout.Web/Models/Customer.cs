using System.Text.Json.Serialization;

namespace FlutterwaveCheckout.Web.Models
{
    public class Customer
    {
        [JsonPropertyName("email")]
        public string email { get; set; }

        [JsonPropertyName("phonenumber")]
        public string phonenumber { get; set; }

        [JsonPropertyName("name")]
        public string name { get; set; }




    }
}
