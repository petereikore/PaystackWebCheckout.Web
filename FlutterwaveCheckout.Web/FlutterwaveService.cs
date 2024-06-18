using FlutterwaveCheckout.Web.Models;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Infrastructure;
using Microsoft.AspNetCore.Mvc.Routing;
using Newtonsoft.Json;
using System.Security.Cryptography.Xml;

namespace FlutterwaveCheckout.Web
{
    public class FlutterwaveService
    {
        private readonly string _secret;
        private readonly ILogger<FlutterwaveService> _logger;
        private readonly HttpContext _httpContext;
        private readonly IUrlHelper _urlHelper;
        public FlutterwaveService(ILogger<FlutterwaveService> logger, IActionContextAccessor actionContext, IUrlHelperFactory urlHelperFactory)
        {
            _secret = "FLWSECK_TEST-c7f3f45e392db2df0258f0f0b2e5167b-X";
            _logger = logger;
            _httpContext = actionContext.ActionContext.HttpContext;
            _urlHelper = urlHelperFactory.GetUrlHelper(actionContext.ActionContext);
        }
        public string BaseUrl => $"{_httpContext.Request.Scheme}://{_httpContext.Request.Host}{_httpContext.Request.PathBase}";

        public async Task<PaymentLinkResponse> GetPaymentLink(PaymentLinkRequest model)
        {
            PaymentLinkResponse result = new();
            try
            {
                model.redirect_url = $"{BaseUrl}/home/index";
                var client = new HttpClient();
                var request = new HttpRequestMessage(HttpMethod.Post, "https://api.flutterwave.com/v3/payments");
                request.Headers.Add("Authorization", $"Bearer {_secret}");
                var content = new StringContent(JsonConvert.SerializeObject(model), null, "application/json");
                request.Content = content;
                var response = await client.SendAsync(request);
                string json = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<PaymentLinkResponse>(json);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex.Message, ex);
            }
            return result;
        }
    }
}
