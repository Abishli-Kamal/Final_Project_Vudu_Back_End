using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;
using Vudu.com_Back_End.Services;
using Vudu.com_Back_End.View_models;
using X.PagedList;

namespace Vudu.com_Back_End.Controllers
{

    public class SubOptionController : Controller
    {
        private readonly AppDbContext _context;
        public SubOptionController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index(int? suboptionId, int? year, int? rating, int? studio, int? tom,int? genre)
        {
            var query = _context.MovieSubOptionSubTitles.Include(m => m.Movie).Include(m => m.Movie.Year).AsQueryable();
            if (suboptionId!=null)
            {
                query=query.Where(m => m.SubOptionSubTitleId==suboptionId);
            }

            ViewBag.Id=suboptionId;
            HomeVM model = new HomeVM
            {
                SubOptions=await _context.SubOptions.ToListAsync(),
                Filters=await _context.Filters.ToListAsync(),
                Genres=await _context.Genres.ToListAsync(),
                Years=await _context.Years.ToListAsync(),
                Studios=await _context.Studios.ToListAsync(),
                Ratings=await _context.Ratings.ToListAsync(),
                Movies=await _context.Movies.Include(k=>k.MovieGenres).ThenInclude(s=>s.Genre).Include(m => m.MovieSubOptionSubTitles).ThenInclude(ms => ms.SubOptionSubTitle).Where(m => m.MovieSubOptionSubTitles.Any(mso => mso.SubOptionSubTitleId==suboptionId)|| m.YearId==year || m.RatingId==rating || m.StudioId==studio || m.TomatometerId==tom || m.MovieGenres.Any(s=>s.GenreId==genre)).ToListAsync(),
                MovieSubOptions=await _context.MovieSubOptions.ToListAsync(),
                Tomatometers=await _context.Tomatometers.ToListAsync(),
                MovieGenres=await _context.MovieGenres.ToListAsync(),
                MovieSubOptionTitles=await _context.MovieSubOptionTitles.ToListAsync(),
                SubOptionTitles=await _context.SubOptionTitles.ToListAsync(),
                SubOptionSubTitles=await _context.SubOptionSubTitles.ToListAsync(),
                MovieSubOptionSubTitles=await query.ToListAsync(),

            };

            return View(model);
        }
    }
}
