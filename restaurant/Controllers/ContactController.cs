using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace restaurant.Controllers
{
    public class ContactController : Controller
    {
        
        public ActionResult Contact()
        {
            return View();
        }

        
    }
}
