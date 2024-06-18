using System.Net.Http;
using System;
using System.Threading.Tasks;
using Newtonsoft.Json;
using Microsoft.Extensions.Logging;
using PaystackWebCheckout.Web.Models.PayStackModels;

namespace PaystackWebCheckout.Web
{
    public class PayStackService
    {
        private readonly ILogger<PayStackService> _logger;
        public PayStackService(ILogger<PayStackService> logger)
        {
            _logger = logger;
        }
        public async Task<PayStackVerificationResponse> Verify(string reference, string secret)
        {
            PayStackVerificationResponse result = new();
            try
            {
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Get, $"https://api.paystack.co/transaction/verify/{reference}");
                request.Headers.Add("Authorization", $"Bearer {secret}");
                var response = await client.SendAsync(request);
                var json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<PayStackVerificationResponse>(json);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
            return result;
        }
    }
}
