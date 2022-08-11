using Microsoft.AspNetCore.Mvc;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    public class AccountController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
