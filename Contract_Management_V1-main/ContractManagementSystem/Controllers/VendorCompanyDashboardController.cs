﻿using Microsoft.AspNetCore.Mvc;

namespace ContractManagementSystem.Controllers
{
  
    public class VendorCompanyDashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult LandingPage()
        {
            return View();
        }
    }
}
