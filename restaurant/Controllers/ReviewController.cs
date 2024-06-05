using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace restaurant.Controllers
{
    public class ReviewController : Controller
    {
       
        public ActionResult Review()
        {
            return View();
        }

    }
}
