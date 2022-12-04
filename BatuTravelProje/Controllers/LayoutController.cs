using Microsoft.AspNetCore.Mvc;

namespace BatuTravelProje.Controllers
{
    public class LayoutController : Controller
    {
        public PartialViewResult Index()
        {
            return PartialView();
        }
    }
}
