using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BatuTravelProje.Controllers
{
    public class GuideController : Controller
    {
        GuideManager guideManager = new GuideManager(new EfGuideDal());
        public IActionResult List()
        {
            var values = guideManager.TGetList();
            return View(values);
        }
    }
}
