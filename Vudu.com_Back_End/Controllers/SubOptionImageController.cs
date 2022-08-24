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
        public async Task<IActionResult> Index(int? imageId, int? year, int? rating, int? studio, int? tom, int? genre)
        {
            ViewBag.Id=imageId;
            HomeVM model = new HomeVM
            {
                SubOptions=await _context.SubOptions.ToListAsync(),
                Filters=await _context.Filters.ToListAsync(),
                Genres=await _context.Genres.ToListAsync(),
                Years=await _context.Years.ToListAsync(),
                Studios=await _context.Studios.ToListAsync(),
                Ratings=await _context.Ratings.ToListAsync(),
                SubOptionImages=await _context.SubOptionImages.ToListAsync(),
                Movies=await _context.Movies.Include(k => k.MovieGenres).ThenInclude(s => s.Genre).Include(m => m.MovieSubOptionImages).ThenInclude(ms => ms.SubOptionImage).Where(m => m.MovieSubOptionImages.Any(mso => mso.SubOptionImageId==imageId)|| m.YearId==year || m.RatingId==rating || m.StudioId==studio || m.TomatometerId==tom || m.MovieGenres.Any(s => s.GenreId==genre)).ToListAsync(),
                MovieSubOptions=await _context.MovieSubOptions.ToListAsync(),
                Tomatometers=await _context.Tomatometers.ToListAsync(),
                MovieGenres=await _context.MovieGenres.ToListAsync(),
                MovieSubOptionTitles=await _context.MovieSubOptionTitles.ToListAsync(),
                SubOptionTitles=await _context.SubOptionTitles.ToListAsync(),
                SubOptionSubTitles=await _context.SubOptionSubTitles.ToListAsync(),
                MovieSubOptionImages=await _context.MovieSubOptionImages.ToListAsync(),
                MovieSubOptionSubTitles=await _context.MovieSubOptionSubTitles.ToListAsync(),

            };

            return View(model);
        }
    }
}
