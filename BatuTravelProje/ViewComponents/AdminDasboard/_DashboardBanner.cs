using Microsoft.AspNetCore.Mvc;

namespace BatuTravelProje.ViewComponents.AdminDasboard
{
    public class _DashboardBanner : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
