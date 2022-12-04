using Microsoft.AspNetCore.Mvc;

namespace BatuTravelProje.ViewComponents.Default
{
    public class _SliderPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
