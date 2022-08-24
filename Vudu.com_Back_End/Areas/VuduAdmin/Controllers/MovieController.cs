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
using X.PagedList;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class MovieController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public MovieController(AppDbContext context, IWebHostEnvironment env)
        {
            _context=context;
            _env=env;
        }
     
        public async Task<IActionResult> Index(int page = 1)
        {

            List<Movie> movie = await _context.Movies.ToListAsync();

            return View(movie.ToPagedList(page, 6));
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
            ViewBag.Actor = await _context.Actors.ToListAsync();
            ViewBag.Year = await _context.Years.ToListAsync();
            ViewBag.Rating = await _context.Ratings.ToListAsync();
            ViewBag.Studio = await _context.Studios.ToListAsync();
            ViewBag.Genre = await _context.Genres.ToListAsync();
            ViewBag.MainOpt = await _context.MainOptions.ToListAsync();
            ViewBag.Genre = await _context.Genres.ToListAsync();
            ViewBag.Trailer = await _context.Trailers.ToListAsync();
            ViewBag.SubOptionImage = await _context.SubOptionImages.ToListAsync();
            ViewBag.SubOptionSubTitle = await _context.SubOptionSubTitles.ToListAsync();
            ViewBag.SubOptionTitle = await _context.SubOptionTitles.ToListAsync();
            ViewBag.IndexOption = await _context.IndexOptions.ToListAsync();
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
            movie.MovieIndexOptions = new List<MovieIndexOption>();
            foreach (int id in movie.IndexOptionIds)
            {
                MovieIndexOption movieIndex = new MovieIndexOption
                {
                    IndexOptionId = id,
                    Movie = movie
                };
                movie.MovieIndexOptions.Add(movieIndex);
            }

            movie.MovieSubOptionTitles = new List<MovieSubOptionTitle>();
            foreach (int id in movie.SubOptionTitleIds)
            {
                MovieSubOptionTitle movieIndex = new MovieSubOptionTitle
                {
                    SubOptionTitleId = id,
                    Movie = movie
                };
                movie.MovieSubOptionTitles.Add(movieIndex);
            }

            movie.MovieGenres = new List<MovieGenre>();
            foreach (int id in movie.GenreIds)
            {
                MovieGenre moviegenre = new MovieGenre
                {
                    GenreId = id,
                    Movie = movie
                };
                movie.MovieGenres.Add(moviegenre);
            }

            movie.MovieSubOptionSubTitles = new List<MovieSubOptionSubTitle>();
            foreach (int id in movie.SubOptionSubTitleIds)
            {
                MovieSubOptionSubTitle submovie = new MovieSubOptionSubTitle
                {
                    SubOptionSubTitleId = id,
                    Movie = movie
                };
                movie.MovieSubOptionSubTitles.Add(submovie);
            }

            movie.MovieSubOptionImages = new List<MovieSubOptionImage>();
            foreach (int id in movie.SubOptionSubTitleIds)
            {
                MovieSubOptionImage submovie = new MovieSubOptionImage
                {
                    SubOptionImageId = id,
                    Movie = movie
                };
                movie.MovieSubOptionImages.Add(submovie);
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
            Movie movie = await _context.Movies.Include(s => s.MovieSubOptionImages).ThenInclude(s => s.SubOptionImage).FirstOrDefaultAsync(m => m.Id==id);
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