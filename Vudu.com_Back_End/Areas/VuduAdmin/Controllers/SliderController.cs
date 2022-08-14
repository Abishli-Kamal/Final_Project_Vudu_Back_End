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
    public class SliderController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public SliderController(AppDbContext context, IWebHostEnvironment env)
        {
            _context=context;
            _env=env;
        }
        public async Task<IActionResult> Index()
        {
            List<Slider> slider = await _context.Sliders.ToListAsync();
            return View(slider);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Slider slider)
        {
            if (!ModelState.IsValid) return View();
            if (slider.Photo!=null)
            {
                if (slider.Photo.Length<1024*1024&&slider.Photo.ContentType.Contains("image"))
                {
                    slider.Image= await slider.Photo.FileCreate(_env.WebRootPath, @"assets\img\Slider"); 
                    await _context.AddAsync(slider);
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
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id==id);
            return View(slider);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Slider slider, int id)
        {
            if (!ModelState.IsValid) return View();
            Slider existedsl = await _context.Sliders.FirstOrDefaultAsync(s => s.Id==id);
            if (existedsl.Id!=slider.Id) return NotFound();
            if (slider.Photo!=null)
            {
                if (slider.Photo.Length<1024*1024&&slider.Photo.ContentType.Contains("image"))
                {
                    string path = _env.WebRootPath + @"assets\img\Slider" + existedsl.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    existedsl.Image = await slider.Photo.FileCreate(_env.WebRootPath, @"assets\img\Slider");
                   

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
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            return View(slider);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteSlider(Slider slider, int id)
        {
            Slider existedSlider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            _context.Sliders.Remove(existedSlider);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Slider slider = await _context.Sliders.FirstOrDefaultAsync(s => s.Id == id);
            return View(slider);
        }
    }
}
