using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    public class FilterController : Controller
    {
        private readonly AppDbContext _context;

        public FilterController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            List<Filter> filter = await _context.Filters.ToListAsync();
            return View(filter);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Filter filter)
        {
            if (!ModelState.IsValid) return View();

            await _context.AddAsync(filter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            Filter filter = await _context.Filters.FirstOrDefaultAsync(s => s.Id==id);
            return View(filter);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Filter filter, int id)
        {
            if (!ModelState.IsValid) return View();
            Filter existedfilter = await _context.Filters.FirstOrDefaultAsync(s => s.Id==id);
            if (filter.Id!=existedfilter.Id) return BadRequest();
            existedfilter.Name=filter.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Filter filter = await _context.Filters.FirstOrDefaultAsync(s => s.Id==id);
            return View(filter);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteFilter(Filter filter)
        {
            if (!ModelState.IsValid) return View();
            _context.Remove(filter);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            Filter filter = await _context.Filters.FirstOrDefaultAsync(s => s.Id==id);
            return View(filter);
        }
    }
}
