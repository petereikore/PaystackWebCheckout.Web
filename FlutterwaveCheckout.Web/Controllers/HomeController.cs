using FlutterwaveCheckout.Web.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace FlutterwaveCheckout.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly FlutterwaveService _service;

        public HomeController(ILogger<HomeController> logger, FlutterwaveService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public async Task<JsonResult> GetPaymentLink([FromBody] PaymentLinkRequest model)
        {
            PaymentLinkResponse result = await _service.GetPaymentLink(model);
            return Json(result);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
