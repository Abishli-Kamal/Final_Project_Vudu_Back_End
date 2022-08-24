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
    public class SubOptionImageController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SubOptionImageController(AppDbContext context, IWebHostEnvironment env)
        {

            
            _context=context;
            _env=env;
        }
        public async Task<IActionResult> Index()
        {
            if (!User.Identity.IsAuthenticated)
            {
                return RedirectToAction("Login", "Account");
            }
            List<SubOptionImage> img = await _context.SubOptionImages.ToListAsync();
            return View(img);
        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(SubOptionImage sub)
        {
            if (!ModelState.IsValid) return View();
            if (sub.Photo!=null)
            {
                if (sub.Photo.Length<1024*1024&&sub.Photo.ContentType.Contains("image"))
                {
                    sub.Image = await sub.Photo.FileCreate(_env.WebRootPath, @"assets\img\Mov-Img-Navbar");
                   
                }
                else
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }

            }
            else
            {
                ModelState.AddModelError("Photo", "Please choose file ");
                return View();
            }
            await _context.SubOptionImages.AddAsync(sub);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            SubOptionImage img = await _context.SubOptionImages.FirstOrDefaultAsync(s => s.Id==id);
            return View(img);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(SubOptionImage sub, int id)
        {
            if (!ModelState.IsValid) return View();
            SubOptionImage existedsub = await _context.SubOptionImages.FirstOrDefaultAsync(s => s.Id==sub.Id);
            if (sub.Id!=existedsub.Id) return BadRequest();

            if (sub.Photo!=null)
            {
                if (sub.Photo.Length<1024*1024&&sub.Photo.ContentType.Contains("image"))
                {

                    string path = _env.WebRootPath + @"assets\img\Mov-Img-Navbar" + existedsub.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    sub.Title=existedsub.Title;
                    sub.MainOptionId=existedsub.MainOptionId;

                    
                }
                else
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
            }
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }
        public async Task<IActionResult> Delete(int id)
        {
            SubOptionImage sub = await _context.SubOptionImages.FirstOrDefaultAsync(s => s.Id == id);
            return View(sub);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteImage(SubOptionImage sub, int id)
        {
            SubOptionImage existedsub = await _context.SubOptionImages.FirstOrDefaultAsync(s => s.Id == id);
            _context.SubOptionImages.Remove(existedsub);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            SubOptionImage sub = await _context.SubOptionImages.FirstOrDefaultAsync(s => s.Id == id);
            return View(sub);
        }
    }
}
