using Microsoft.AspNetCore.Mvc;

namespace BatuTravelProje.Areas.Member.Controllers
{
    public class MessageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
