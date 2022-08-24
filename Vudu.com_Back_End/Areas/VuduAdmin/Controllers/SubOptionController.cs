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
    public class SubOptionController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SubOptionController(AppDbContext context, IWebHostEnvironment env)
        {

            
            _context=context;
            _env=env;
        }
        public async Task<IActionResult> Index()
        {
            
            List<SubOption> subOptions = await _context.SubOptions.ToListAsync();
            return View(subOptions);
        }
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(SubOption sub)
        {
            if (!ModelState.IsValid) return View();
            if (sub.Photo!=null)
            {
                if (sub.Photo.Length<1024*1024&&sub.Photo.ContentType.Contains("image"))
                {
                    sub.Image = await sub.Photo.FileCreate(_env.WebRootPath, @"assets\img\Mov-Img-Navbar");
                    await _context.SubOptions.AddAsync(sub);
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
            SubOption subOptions = await _context.SubOptions.FirstOrDefaultAsync(s => s.Id==id);
            return View(subOptions);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(SubOption sub, int id)
        {
            if (!ModelState.IsValid) return View();
            SubOption existedsub = await _context.SubOptions.FirstOrDefaultAsync(s => s.Id==id);
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
                    sub.SubTitle=existedsub.SubTitle;
                    sub.ImageName=existedsub.ImageName;
                    sub.MainOptionId=existedsub.MainOptionId;

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
    }
}
