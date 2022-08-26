using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;
using X.PagedList;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{

    [Area("VuduAdmin")]

    [Authorize(Roles ="Admin,SuperAdmin")]
    public class TrailerController : Controller
    {
        private readonly AppDbContext _context;

        public TrailerController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index(int page=1)
        {

           
            List<Trailer> trailer = await _context.Trailers.ToListAsync();
            return View(trailer.ToPagedList(page,5));
        }
        public async Task< IActionResult> Create()
        {
            ViewBag.Movie= await _context.Movies.ToListAsync();
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Trailer trailer)
        {
            ViewBag.Movie= await _context.Movies.ToListAsync();
            if (!ModelState.IsValid) return View();

            await _context.AddAsync(trailer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            ViewBag.Movie= await _context.Movies.ToListAsync();
            Trailer trailer = await _context.Trailers.FirstOrDefaultAsync(s => s.Id==id);
            return View(trailer);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Trailer trailer, int id)
        {
            ViewBag.Movie= await _context.Movies.ToListAsync();
            if (!ModelState.IsValid) return View();
            Trailer existedrt = await _context.Trailers.FirstOrDefaultAsync(s => s.Id==id);
            if (trailer.Id!=existedrt.Id) return BadRequest();
            existedrt.Title=trailer.Title;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            ViewBag.Movie= await _context.Movies.ToListAsync();
            Trailer trailer = await _context.Trailers.Include(m=>m.Movie).FirstOrDefaultAsync(s => s.Id==id);
            return View(trailer);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
    
        public async Task<IActionResult> DeleteTr(Trailer trailer)
        {
            if (!ModelState.IsValid) return View();
            _context.Remove(trailer);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            Trailer trailer = await _context.Trailers.Include(m=>m.Movie).FirstOrDefaultAsync(s => s.Id==id);
            return View(trailer);
        }
    }
}
