using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    public class YearController : Controller
    {
        private readonly AppDbContext _context;

        public YearController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            List<Year> year = await _context.Years.ToListAsync();
            return View(year);
        }
        public async Task<IActionResult> Create()
        {
            ViewBag.Filters = await _context.Filters.ToListAsync();
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Year year)
        {
            if (!ModelState.IsValid) return View();

            await _context.AddAsync(year);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            Year year = await _context.Years.FirstOrDefaultAsync(s => s.Id==id);
            return View(year);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Year year, int id)
        {
            if (!ModelState.IsValid) return View();
            Year existedrt = await _context.Years.FirstOrDefaultAsync(s => s.Id==id);
            if (year.Id!=existedrt.Id) return BadRequest();
            existedrt.Name=year.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Year year = await _context.Years.FirstOrDefaultAsync(s => s.Id==id);
            return View(year);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteYear(Year year)
        {
            if (!ModelState.IsValid) return View();
            _context.Remove(year);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            Year year = await _context.Years.FirstOrDefaultAsync(s => s.Id==id);
            return View(year);
        }
    }
}
