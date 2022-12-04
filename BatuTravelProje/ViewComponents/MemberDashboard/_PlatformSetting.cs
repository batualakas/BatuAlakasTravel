using BusinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace BatuTravelProje.ViewComponents.MemberDashboard
{
    public class _PlatformSetting : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }
    }
}
