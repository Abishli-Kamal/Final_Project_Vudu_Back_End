
using Microsoft.AspNetCore.Authorization;
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
        [Authorize]
        public async Task<IActionResult> Index()
        {
            HomeVM model = new HomeVM
            {
                Movies=await _context.Movies.ToListAsync(),
                MovieGenres=await _context.MovieGenres.ToListAsync(),
                Genres=await _context.Genres.ToListAsync(),
                Ratings=await _context.Ratings.ToListAsync(),
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
