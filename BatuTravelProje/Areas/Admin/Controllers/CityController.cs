using BatuTravelProje.Models;
using BusinessLayer.Abstract;
using EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace BatuTravelProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CityController : Controller
    {
        private readonly IDestinationService _destinationService;
        public CityController(IDestinationService destinationService)
        {
            _destinationService = destinationService;
        }
        public IActionResult Index()
        {
            return View();
        }
        // Şehirleri listeleme işlemi 
        public IActionResult CityList()
        {
            var jsonCity = JsonConvert.SerializeObject(_destinationService.TGetList());

            return Json(jsonCity);
        }
        [HttpPost]
        public IActionResult AddCityDestination(Destination destination)
        {
            _destinationService.TAdd(destination);
            var values = JsonConvert.SerializeObject(destination); 
            return Json(values);
        }
        public IActionResult GetById(int id)
        {
            var values = _destinationService.TGetByID(id);
            var jsonValues = JsonConvert.SerializeObject(values);
            return Json(jsonValues);
        }
    }
}
