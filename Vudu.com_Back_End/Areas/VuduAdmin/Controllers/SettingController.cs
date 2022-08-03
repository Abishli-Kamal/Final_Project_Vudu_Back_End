using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;
using Vudu.com_Back_End.Utilities;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    public class SettingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SettingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context = context;
            _env = env;
        }
        public async Task<IActionResult> Index()
        {
            List<Setting> settings = await _context.Settings.ToListAsync();
            return View(settings);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Setting setting)
        {
            if (!ModelState.IsValid) return View();
            if (setting.Photo != null)
            {
                if (setting.Photo.Length<1024*1024&&setting.Photo.ContentType.Contains("image"))
                {
                    setting.Value = await setting.Photo.FileCreate(_env.WebRootPath, @"assets\img");
                    await _context.AddAsync(setting);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
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
        }
        public async Task<IActionResult> Edit(int id)
        {
            Setting setting = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id);
            return View(setting);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(int id, Setting setting)
        {
            if (!ModelState.IsValid) return View();
            Setting existedsetting = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id);
            if (setting.Photo !=null)
            {
                if (setting.Photo.Length<1024*1024&&setting.Photo.ContentType.Contains("image"))
                {
                    string path = _env.WebRootPath + @"\assets\img" + existedsetting.Value;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    existedsetting.Value = await setting.Photo.FileCreate(_env.WebRootPath, @"assets\img");
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
            }
            existedsetting.Key = setting.Key;
            existedsetting.Value = setting.Value;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Delete(int id)
        {
            Setting setting = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id);
            return View(setting);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSet(int id)
        {
            Setting existed = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id);
            _context.Settings.Remove(existed);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            Setting setting = await _context.Settings.FirstOrDefaultAsync(s => s.Id == id);
            return View(setting);
        }


    }
}
