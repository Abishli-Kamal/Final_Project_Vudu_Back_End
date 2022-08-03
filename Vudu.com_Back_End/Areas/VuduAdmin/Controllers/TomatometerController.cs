using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    public class TomatometerController : Controller
    {
        private readonly AppDbContext _context;

        public TomatometerController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            List<Tomatometer> tom = await _context.Tomatometers.ToListAsync();
            return View(tom);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Filters = await _context.Filters.ToListAsync();
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Tomatometer tom)
        {
            if (!ModelState.IsValid) return View();

            await _context.AddAsync(tom);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            Tomatometer tom = await _context.Tomatometers.FirstOrDefaultAsync(s => s.Id==id);
            return View(tom);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Tomatometer tom, int id)
        {
            if (!ModelState.IsValid) return View();
            Tomatometer existedrt = await _context.Tomatometers.FirstOrDefaultAsync(s => s.Id==id);
            if (tom.Id!=existedrt.Id) return BadRequest();
            existedrt.Title=tom.Title;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Tomatometer tom = await _context.Tomatometers.FirstOrDefaultAsync(s => s.Id==id);
            return View(tom);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteTom(Tomatometer tom)
        {
            if (!ModelState.IsValid) return View();
            _context.Remove(tom);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            Tomatometer tom = await _context.Tomatometers.FirstOrDefaultAsync(s => s.Id==id);
            return View(tom);
        }
    }
}
