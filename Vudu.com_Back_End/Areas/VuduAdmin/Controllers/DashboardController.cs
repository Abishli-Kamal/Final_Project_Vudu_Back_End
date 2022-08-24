using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class DashboardController : Controller
    {
     
        public IActionResult Index()
        {

           
            return View();
        }
    }
}
