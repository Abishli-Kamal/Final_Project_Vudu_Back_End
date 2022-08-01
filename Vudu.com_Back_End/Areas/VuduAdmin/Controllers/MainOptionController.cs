using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    public class MainOptionController : Controller
    {
        private readonly AppDbContext _context;

        public MainOptionController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {
            List<MainOption> mainOptions = await _context.MainOptions.ToListAsync();
            return View(mainOptions);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(MainOption main)
        {
            if (!ModelState.IsValid) return View();
            if (main==null)
            {
                ModelState.AddModelError("Name", "Write main option");
                return View();
            }
            await _context.AddAsync(main);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            MainOption main = await _context.MainOptions.FirstOrDefaultAsync(s => s.Id==id);
            return View(main);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit( MainOption main, int id)
        {
            if (!ModelState.IsValid) return View();
            MainOption existedOption=await _context.MainOptions.FirstOrDefaultAsync(s => s.Id==id);
            if (main.Id!=existedOption.Id) return BadRequest();
            existedOption.Name=main.Name;   
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            MainOption main = await _context.MainOptions.FirstOrDefaultAsync(s => s.Id==id);
            return View(main);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteMainOption(MainOption main)
        {
            if (!ModelState.IsValid) return View();

             _context.Remove(main);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            MainOption main = await _context.MainOptions.FirstOrDefaultAsync(s => s.Id==id);
            return View(main);
        }
    }
}
