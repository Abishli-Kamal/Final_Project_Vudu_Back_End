using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Controllers
{
    public class TrailerController : Controller
    {
        private readonly AppDbContext _context;

        public TrailerController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index(int id)
        {
            
            Trailer trailers = await _context.Trailers.Include(s=>s.Movie).FirstOrDefaultAsync(t=>t.MovieId==id);
            return View(trailers);

        }
    }
}
