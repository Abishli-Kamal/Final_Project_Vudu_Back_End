using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    public class GenreController : Controller
    {
        private readonly AppDbContext _context;

        public GenreController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            List<Genre> genre = await _context.Genres.ToListAsync();
            return View(genre);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Genre genre)
        {
            if (!ModelState.IsValid) return View();

            await _context.AddAsync(genre);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            Genre genre = await _context.Genres.FirstOrDefaultAsync(s => s.Id==id);
            return View(genre);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Genre genre, int id)
        {
            if (!ModelState.IsValid) return View();
            Genre existedrt = await _context.Genres.FirstOrDefaultAsync(s => s.Id==id);
            if (genre.Id!=existedrt.Id) return BadRequest();
            existedrt.Name=genre.Name;
            existedrt.FilterId=genre.FilterId;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Genre genre = await _context.Genres.FirstOrDefaultAsync(s => s.Id==id);
            return View(genre);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteGenre(Genre genre)
        {
            if (!ModelState.IsValid) return View();
            _context.Remove(genre);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            Genre genre = await _context.Genres.FirstOrDefaultAsync(s => s.Id==id);
            return View(genre);
        }
    }
}
