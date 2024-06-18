using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using PaystackWebCheckout.Web.Models;
using System.Diagnostics;
using System.Threading.Tasks;

namespace PaystackWebCheckout.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PayStackService _payStackService;
        public HomeController(ILogger<HomeController> logger, PayStackService payStackService)
        {
            _logger = logger;
            _payStackService = payStackService;
        }

        public IActionResult Index()
        {
            return View(new IndexViewModel());
        }

        [HttpGet]
        public async Task<JsonResult> Verify(string reference, decimal amount)
        {
            var result = await _payStackService.Verify(reference, "sk_live_a1f163ae71b3eb26870ca0d49a8b9f7263933330");
            if (result.Data.Status == "success" && result.Data.Amount==amount*100)
            {
                //Give value to the customer
                return Json(new { status = true });
            }
            return Json(new { status = false });
        }

        public IActionResult TransactionVerification()
        {
            return View();
        }

        [HttpGet]
        public IActionResult SuccessfulTransaction()
        {
            return View();
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
