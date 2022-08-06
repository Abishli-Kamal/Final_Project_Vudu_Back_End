using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    public class ActorController : Controller
    {
        private readonly AppDbContext _context;

        public ActorController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            List<Actor> actor = await _context.Actors.ToListAsync();
            return View(actor);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Movies = await _context.Movies.ToListAsync();
            return View();
        }

    }
}
