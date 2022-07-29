using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.View_models;

namespace Vudu.com_Back_End.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;

        public HomeController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Settings=await _context.Settings.ToListAsync(),
                Sliders=await _context.Sliders.ToListAsync(),
                MainOptions=await _context.MainOptions.ToListAsync(),
                SubOptions=await _context.SubOptions.ToListAsync(),
            };
            return View(model);
        }
    }
}
