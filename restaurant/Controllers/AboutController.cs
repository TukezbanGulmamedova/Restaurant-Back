using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace restaurant.Controllers
{
    public class AboutController : Controller
    {
    
        public ActionResult About()
        {
            return View();
        }

    }
}
