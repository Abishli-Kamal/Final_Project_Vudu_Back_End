using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.View_models;

namespace Vudu.com_Back_End.Controllers
{
    public class SubOptiontTitleController : Controller
    {
        private readonly AppDbContext _context;

        public SubOptiontTitleController(AppDbContext context)
        {
            _context=context;
        }

        public async Task<IActionResult> Index(int? titleId, int? year, int? rating, int? studio, int? tom, int? genre)
        {
            ViewBag.Id=titleId;
            HomeVM model = new HomeVM
            {
                SubOptions=await _context.SubOptions.ToListAsync(),
                Filters=await _context.Filters.ToListAsync(),
                Genres=await _context.Genres.ToListAsync(),
                Years=await _context.Years.ToListAsync(),
                Studios=await _context.Studios.ToListAsync(),
                Ratings=await _context.Ratings.ToListAsync(),
                Movies=await _context.Movies.Include(k => k.MovieGenres).ThenInclude(s => s.Genre).Include(m => m.MovieSubOptionTitles).ThenInclude(ms => ms.SubOptionTitle).Where(m => m.MovieSubOptionTitles.Any(mso => mso.SubOptionTitleId==titleId)|| m.YearId==year || m.RatingId==rating || m.StudioId==studio || m.TomatometerId==tom || m.MovieGenres.Any(s => s.GenreId==genre)).ToListAsync(),
                MovieSubOptions=await _context.MovieSubOptions.ToListAsync(),
                Tomatometers=await _context.Tomatometers.ToListAsync(),
                MovieGenres=await _context.MovieGenres.ToListAsync(),
                MovieSubOptionTitles=await _context.MovieSubOptionTitles.ToListAsync(),
                SubOptionTitles=await _context.SubOptionTitles.ToListAsync(),
                SubOptionSubTitles=await _context.SubOptionSubTitles.ToListAsync(),
                MovieSubOptionSubTitles=await _context.MovieSubOptionSubTitles.ToListAsync(),

            };

            return View(model);
        }
    }
}
