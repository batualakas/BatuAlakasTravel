﻿using Microsoft.AspNetCore.Mvc;

namespace BatuTravelProje.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
