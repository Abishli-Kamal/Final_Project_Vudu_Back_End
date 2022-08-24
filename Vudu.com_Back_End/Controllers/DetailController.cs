using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;
using Vudu.com_Back_End.View_models;

namespace Vudu.com_Back_End.Controllers
{
    public class DetailController : Controller
    {
        private readonly AppDbContext _context;

        public DetailController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index(int id)
        {
            Movie movie = await _context.Movies.Include(j => j.MovieGenres).ThenInclude(s=>s.Genre).Include(j => j.Year).Include(j => j.Rating).Include(j => j.Studio).Include(j => j.ActorMovies).ThenInclude(s=>s.Actor).FirstOrDefaultAsync(m => m.Id==id);

            if (movie==null) return NotFound();



            HomeVM model = new HomeVM
            {
                Genres=await _context.Genres.ToListAsync(),
                Studios=await _context.Studios.ToListAsync(),
                Ratings=await _context.Ratings.ToListAsync(),
                Tomatometers=await _context.Tomatometers.ToListAsync(),
                MovieGenres=await _context.MovieGenres.ToListAsync(),
                Actors=await _context.Actors.ToListAsync(),
                ActorMovies=await _context.ActorMovies.ToListAsync(),
                Movie=movie
            };
            return View(model);

        }


    }
}
