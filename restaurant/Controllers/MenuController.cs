using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace restaurant.Controllers
{
    public class MenuController : Controller
    {
  
        public ActionResult Menu()
        {
            return View();
        }

    }
}
