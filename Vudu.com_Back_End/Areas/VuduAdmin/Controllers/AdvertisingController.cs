using Microsoft.AspNetCore.Authorization;
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
    [Authorize(Roles = "Admin,SuperAdmin")]
    public class AdvertisingController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;
        public AdvertisingController(AppDbContext context, IWebHostEnvironment env)
        {
            _context=context;
            _env=env;
        }
        public async Task<IActionResult> Index()
        {

            List<Advertising> advertising = await _context.Advertisings.ToListAsync();
            return View(advertising);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Advertising advertising)
        {
            if (!ModelState.IsValid) return View();
            if (advertising.Photo!=null)
            {
                if (advertising.Photo.Length<1024*1024&&advertising.Photo.ContentType.Contains("image"))
                {
                    advertising.Image= await advertising.Photo.FileCreate(_env.WebRootPath, @"assets\img\Releases");
                    await _context.AddAsync(advertising);
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
            Advertising advertising = await _context.Advertisings.FirstOrDefaultAsync(s => s.Id==id);
            return View(advertising);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Advertising advertising, int id)
        {
            if (!ModelState.IsValid) return View();
            Advertising existed = await _context.Advertisings.FirstOrDefaultAsync(s => s.Id==id);
            if (advertising.Id!=existed.Id) return NotFound();

            if (advertising.Photo!=null)
            {
                if (advertising.Photo.Length<1024*1024&&advertising.Photo.ContentType.Contains("image"))
                {
                    existed.Image = await advertising.Photo.FileCreate(_env.WebRootPath, @"assets\img\Releases");
                    string path = _env.WebRootPath + @"assets\img\Releases" + existed.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
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

        public async Task<IActionResult> Delete(int id)
        {
            Advertising advertising = await _context.Advertisings.FirstOrDefaultAsync(s => s.Id==id);
            return View(advertising);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteAdvr(int id)
        {
            Advertising advertising = await _context.Advertisings.FirstOrDefaultAsync(s => s.Id == id);
            _context.Advertisings.Remove(advertising);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Advertising advertising = await _context.Advertisings.FirstOrDefaultAsync(s => s.Id==id);
            return View(advertising);
        }
    }
}
