using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.View_models;

namespace Vudu.com_Back_End.Controllers
{
    public class SubOptionImageController : Controller
    {
        private readonly AppDbContext _context;

        public SubOptionImageController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index(int? imageId, int id)
        {
            var query = _context.MovieSubOptionImages.AsQueryable();
            if (imageId!=null)
            {
                query=query.Where(m => m.SubOptionImage.Id==imageId);
            }

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
                MovieSubOptionImages=await query.ToListAsync(),

                SubOptionSubTitles=await _context.SubOptionSubTitles.ToListAsync(),
                SubOptionImages=await _context.SubOptionImages.ToListAsync(),
                BasketItems= await _context.BasketItems.ToListAsync(),
            };
            return View(model);
        }
    }
}
