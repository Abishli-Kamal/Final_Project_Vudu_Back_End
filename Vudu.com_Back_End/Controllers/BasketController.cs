
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;
using Vudu.com_Back_End.View_models;

namespace Vudu.com_Back_End.Controllers
{
    public class BasketController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public BasketController(AppDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager=userManager;
        }
        public async Task<IActionResult> Index()
        {
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
                BasketItems= await _context.BasketItems.ToListAsync(),

            };
            return View(model);
        }

        public async Task<IActionResult> BasketAdd(int id)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(p => p.Id == id);
            if (movie == null) return NotFound();
            AppUser user = await _userManager.FindByNameAsync(User.Identity.Name);

            BasketItem basketItem = await _context.BasketItems.FirstOrDefaultAsync(a => a.AppUserId==user.Id&& a.MovieId==movie.Id);

            if (basketItem==null)
            {
                BasketItem basketadd = new BasketItem
                {

                    Movie=movie,
                    AppUser=user,

                };
                _context.BasketItems.Add(basketadd);


            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Home");
        }
        public async Task<IActionResult> DeleteBasket(int id)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(p => p.Id == id);
            if (movie == null) return NotFound();

            BasketItem basketItem = await _context.BasketItems.FirstOrDefaultAsync(a =>a.MovieId==movie.Id);

            if (basketItem!=null)
            {
                _context.BasketItems.Remove(basketItem);
            }
            await _context.SaveChangesAsync();
            return RedirectToAction("Index", "Basket");
        }

    }
}
