using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace restaurant.Areas.Admin.Controllers   
{
[Area("Admin")]
public class DashboardController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
