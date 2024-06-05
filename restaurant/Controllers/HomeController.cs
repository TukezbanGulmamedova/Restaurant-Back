using Microsoft.AspNetCore.Mvc;
using restaurant.Data;
using restaurant.Models;
using System.Diagnostics;

namespace restaurant.Controllers
{
    public class HomeController : Controller
    {
  
      
        public IActionResult Index()
        {
            return View();
        }

       
    }
}