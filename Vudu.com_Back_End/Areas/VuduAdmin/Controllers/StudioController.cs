using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class StudioController : Controller
    {
        private readonly AppDbContext _context;

        public StudioController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {

            List<Studio> studio = await _context.Studios.ToListAsync();
            return View(studio);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Studio rt)
        {
            if (!ModelState.IsValid) return View();

            await _context.AddAsync(rt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            Studio rt = await _context.Studios.FirstOrDefaultAsync(s => s.Id==id);
            return View(rt);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Studio rt, int id)
        {
            if (!ModelState.IsValid) return View();
            Studio existedrt = await _context.Studios.FirstOrDefaultAsync(s => s.Id==id);
            if (rt.Id!=existedrt.Id) return BadRequest();
            existedrt.Name=rt.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Studio rt = await _context.Studios.FirstOrDefaultAsync(s => s.Id==id);
            return View(rt);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteStudio(Studio rt)
        {
            if (!ModelState.IsValid) return View();
            _context.Remove(rt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            Studio rt = await _context.Studios.FirstOrDefaultAsync(s => s.Id==id);
            return View(rt);
        }
    }
}
