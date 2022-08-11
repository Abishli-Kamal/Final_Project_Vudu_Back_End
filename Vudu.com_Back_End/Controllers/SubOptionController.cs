using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;

namespace Vudu.com_Back_End.Controllers
{

    public class SubOptionController : Controller
    {
        private readonly AppDbContext _context;

        public SubOptionController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            return View();
        }
    }
}
