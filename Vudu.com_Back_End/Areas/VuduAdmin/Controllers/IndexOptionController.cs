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
    public class IndexOptionController : Controller
    {
        private readonly AppDbContext _context;

        public IndexOptionController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {

            List<IndexOption> options = await _context.IndexOptions.ToListAsync();
            return View(options);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(IndexOption opt)
        {
            if (!ModelState.IsValid) return View();
            if (opt==null)
            {
                ModelState.AddModelError("Name", "Write index option");
                return View();
            }
            await _context.AddAsync(opt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            IndexOption sub = await _context.IndexOptions.FirstOrDefaultAsync(s => s.Id==id);
            return View(sub);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(IndexOption opt, int id)
        {
            if (!ModelState.IsValid) return View();
            IndexOption existedOption = await _context.IndexOptions.FirstOrDefaultAsync(s => s.Id==id);
            if (opt.Id!=existedOption.Id) return BadRequest();
            existedOption.Name=opt.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            IndexOption opt = await _context.IndexOptions.FirstOrDefaultAsync(s => s.Id==id);
            return View(opt);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteOption(IndexOption opt)
        {
            if (!ModelState.IsValid) return View();
            _context.Remove(opt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
    }
}
