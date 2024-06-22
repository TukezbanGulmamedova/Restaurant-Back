using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ActionConstraints;

namespace restaurant.Areas.Admin.Controllers   
{
[Area("Admin")]
//[Authorize(Roles = "Admin")]
    public class DashboardController: Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
