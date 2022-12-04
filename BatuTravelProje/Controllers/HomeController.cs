using BatuTravelProje.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Diagnostics;

namespace BatuTravelProje.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        // outputlarda Bilgileri görmek için loginformation kullandım.
        // Sadece öğrenmek için yaptım . bu sayfanın bende geri dönüşü yok zaten
        public HomeController(ILogger<HomeController> logger)
        {
            _logger.LogInformation("Index Sayfası Çağırıldı");
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            // Çağırılan zamanı da görmek için
            DateTime d = Convert.ToDateTime(DateTime.Now.ToLongDateString());
            _logger.LogInformation(d+ " Privacy sayfası çağırıldı");
            return View();
        }
        public IActionResult Test()
        {
            _logger.LogInformation("Test Sayfası Çağırıldı");
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}