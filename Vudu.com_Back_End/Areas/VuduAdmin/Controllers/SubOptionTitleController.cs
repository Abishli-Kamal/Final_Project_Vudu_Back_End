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
    public class SubOptionTitleController : Controller
    {
        private readonly AppDbContext _context;

        public SubOptionTitleController(AppDbContext context)
        {
            _context=context;
        }
        public  async Task<IActionResult> Index()
        {

            List<SubOptionTitle> subOptionTitles = await _context.SubOptionTitles.ToListAsync();
            return View(subOptionTitles);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(SubOptionTitle sub)
        {
            if (!ModelState.IsValid) return View();
            if (sub==null)
            {
                ModelState.AddModelError("Title", "Write sub option");
                return View();
            }
            await _context.AddAsync(sub);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            SubOptionTitle sub = await _context.SubOptionTitles.FirstOrDefaultAsync(s => s.Id==id);
            return View(sub);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(SubOptionTitle sub, int id)
        {
            if (!ModelState.IsValid) return View();
            SubOptionTitle existedOption = await _context.SubOptionTitles.FirstOrDefaultAsync(s => s.Id==id);
            if (sub.Id!=existedOption.Id) return BadRequest();
            existedOption.Title=sub.Title;
            existedOption.MainOptionId=sub.MainOptionId;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            SubOptionTitle sub = await _context.SubOptionTitles.FirstOrDefaultAsync(s => s.Id==id);
            return View(sub);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSubTitle(SubOptionTitle sub)
        {
            if (!ModelState.IsValid) return View();
           _context.Remove(sub);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            SubOptionTitle sub = await _context.SubOptionTitles.FirstOrDefaultAsync(s => s.Id==id);
            return View(sub);
        }

    }
}
