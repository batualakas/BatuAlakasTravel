using BusinessLayer.Concrete;
using DataAccessLayer.EntityFramework;
using Microsoft.AspNetCore.Mvc;

namespace BatuTravelProje.ViewComponents.Default
{
    public class _PopularPartial : ViewComponent
    {

        DestinationManager destinationManager = new DestinationManager(new EfDestinationDal());
        public IViewComponentResult Invoke()
        {
            var values = destinationManager.TGetList();
            return View(values);
        }
    }
}
