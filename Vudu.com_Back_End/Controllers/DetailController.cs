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
            if (id==7)
            {
                id-=4;
            }
            if (id==8)
            {
                id-=3;
            }
            if (12>id &&id>8)
            {
                id-=2;
            }
            if (id==12)
            {
                id=6;
            }
            if (id>12)
            {
                id-=3;
            }
            if (id>41)
            {
                id-=1;
            }
            if (id>51&&id<60)
            {
                id-=1;
            }
            if (id>60&&id<70)
            {
                id-=4;
            }

            Movie movie = await _context.Movies.Include(j => j.MovieGenres).FirstOrDefaultAsync(m => m.Id==id);

            if (movie==null) return NotFound();



            HomeVM model = new HomeVM
            {
                Settings=await _context.Settings.ToListAsync(),
                Sliders=await _context.Sliders.ToListAsync(),
                MainOptions=await _context.MainOptions.ToListAsync(),
                SubOptions=await _context.SubOptions.ToListAsync(),
                Filters=await _context.Filters.ToListAsync(),
                Genres=await _context.Genres.ToListAsync(),
                Years=await _context.Years.ToListAsync(),
                Studios=await _context.Studios.ToListAsync(),
                Ratings=await _context.Ratings.ToListAsync(),
                Movies=await _context.Movies.ToListAsync(),
                MovieSubOptions=await _context.MovieSubOptions.ToListAsync(),
                Tomatometers=await _context.Tomatometers.ToListAsync(),
                MovieGenres=await _context.MovieGenres.ToListAsync(),
                Actors=await _context.Actors.ToListAsync(),
                ActorMovies=await _context.ActorMovies.ToListAsync(),
                MovieIndexOptions=await _context.MovieIndexOptions.ToListAsync(),
                IndexOptions=await _context.IndexOptions.ToListAsync(),
                Advertisings=await _context.Advertisings.ToListAsync(),
                MovieSubOptionTitles=await _context.MovieSubOptionTitles.ToListAsync(),
                SubOptionTitles=await _context.SubOptionTitles.ToListAsync(),
                MovieSubOptionSubTitles=await _context.MovieSubOptionSubTitles.ToListAsync(),
                SubOptionSubTitles=await _context.SubOptionSubTitles.ToListAsync(),
                SubOptionImages=await _context.SubOptionImages.ToListAsync(),
                Movie=movie
            };
            return View(model);

        }


    }
}
