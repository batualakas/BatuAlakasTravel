using Microsoft.AspNetCore.Mvc;

namespace BatuTravelProje.ViewComponents.AdminDasboard
{
    public class _AdminDashboardHeader : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
