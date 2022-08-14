using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;
using Vudu.com_Back_End.Utilities;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
    
        public MovieController(AppDbContext context, IWebHostEnvironment env)
        {
            _context=context;
            _env=env;
        }
        //[Authorize(Policy = "MovieManager")]
        public async Task<IActionResult> Index()
        {
            List<Movie> actor = await _context.Movies.ToListAsync();
            return View(actor);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Actor = await _context.Actors.ToListAsync();
            ViewBag.Year = await _context.Years.ToListAsync();
            ViewBag.Rating = await _context.Ratings.ToListAsync();
            ViewBag.Studio = await _context.Studios.ToListAsync();
            ViewBag.Genre = await _context.Genres.ToListAsync();
            ViewBag.MainOpt = await _context.MainOptions.ToListAsync();
            ViewBag.Genre = await _context.Genres.ToListAsync();
            ViewBag.SubOptionImage = await _context.SubOptionImages.ToListAsync();
            ViewBag.SubOptionSubTitle = await _context.SubOptionSubTitles.ToListAsync();
            ViewBag.SubOptionTitle = await _context.SubOptionTitles.ToListAsync();
            ViewBag.IndexOption = await _context.IndexOptions.ToListAsync();
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Movie movie)
        {
            if (!ModelState.IsValid) return View();
            if (movie.MainImage!=null)
            {
                if (movie.MainImage.Length<1024*1024&&movie.MainImage.ContentType.Contains("image"))
                {
                    movie.Image= await movie.MainImage.FileCreate(_env.WebRootPath, @"assets\img\Releases");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
            }
            else
            {

                ModelState.AddModelError("Photo", "Please choose file");
                return View();
            }
            if (movie.BackgroundImage!=null)
            {
                if (movie.BackgroundImage.Length<1024*1024&&movie.BackgroundImage.ContentType.Contains("image"))
                {
                    movie.BackImage= await movie.BackgroundImage.FileCreate(_env.WebRootPath, @"assets\img\Releases\DetailBack");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
            }
            await _context.AddAsync(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Edit(int id)
        {
            Movie movie = await _context.Movies.FindAsync(id);
            return View(movie);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Movie movie, int id)
        {
            if (!ModelState.IsValid) return View();
            Movie existedmovie = await _context.Movies.FirstOrDefaultAsync(s => s.Id==id);
            if (movie.Id!=existedmovie.Id) return NotFound();
            if (movie.MainImage!=null)
            {
                if (movie.MainImage.Length<1024*1024&&movie.MainImage.ContentType.Contains("image"))
                {
                    existedmovie.Image= await movie.MainImage.FileCreate(_env.WebRootPath, @"assets\img\Releases");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
            }
            if (movie.BackgroundImage!=null)
            {
                if (movie.BackgroundImage.Length<1024*1024&&movie.BackgroundImage.ContentType.Contains("image"))
                {
                    existedmovie.BackImage= await movie.BackgroundImage.FileCreate(_env.WebRootPath, @"assets\img\Releases\DetailBack");
                }
                else
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
            }
            existedmovie.Name=movie.Name;
            existedmovie.RottenTomatoes=movie.RottenTomatoes;
            existedmovie.InfoMovie=movie.InfoMovie;
            existedmovie.Description=movie.Description;
            existedmovie.Age=movie.Age;
            existedmovie.Language=movie.Language;
            existedmovie.Length=movie.Length;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(m => m.Id==id);
            return View(movie);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteMovie(int id)
        {
            Movie movie = await _context.Movies.FirstOrDefaultAsync(m=>m.Id==id);
            _context.Remove(movie);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Detail(int id)
        {
            Movie movie = await _context.Movies.FindAsync(id);
            return View(movie);
        }
    }
}