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
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class ActorController : Controller
    {
        private readonly AppDbContext _context;
        private readonly IWebHostEnvironment _env;

        public ActorController(AppDbContext context,IWebHostEnvironment env)
        {
            _context=context;
            _env=env;
        }
        public async Task<IActionResult> Index()
        {

           
            List<Actor> actor = await _context.Actors.ToListAsync();
            return View(actor);
        }
        public async Task<IActionResult> Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Actor actor)
        {
            if (!ModelState.IsValid) return View();
            if (actor.Photo!=null)
            {
                if (actor.Photo.Length<1024*1024&&actor.Photo.ContentType.Contains("image"))
                {
                    actor.Image= await actor.Photo.FileCreate(_env.WebRootPath, @"assets\img\Actors\OneMovies");

                    await _context.AddAsync(actor);
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
            Actor actor = await _context.Actors.FirstOrDefaultAsync(a => a.Id==id);
            return View(actor);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Actor actor, int id)
        {
            if (!ModelState.IsValid) return View();
            Actor existedAc = await _context.Actors.FirstOrDefaultAsync(s => s.Id==id);
            if (existedAc.Id!=actor.Id) return NotFound();
            if (actor.Photo!=null)
            {
                if (actor.Photo.Length<1024*1024&&actor.Photo.ContentType.Contains("image"))
                {
                    string path = _env.WebRootPath + @"assets\img\Actors\OneMovies" + existedAc.Image;
                    if (System.IO.File.Exists(path))
                    {
                        System.IO.File.Delete(path);
                    }
                    existedAc.Image = await actor.Photo.FileCreate(_env.WebRootPath, @"assets\img\Actors\OneMovies");


                }
                else
                {
                    ModelState.AddModelError("Photo", "Please choose supported file");
                    return View();
                }
            }
            existedAc.Name=actor.Name;
            existedAc.Duty=actor.Duty;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
        public async Task<IActionResult> Delete(int id)
        {
            Actor actor = await _context.Actors.FirstOrDefaultAsync(s => s.Id == id);
            return View(actor);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteActor(Actor actor, int id)
        {
            Actor existedactor = await _context.Actors.FirstOrDefaultAsync(s => s.Id == id);
            _context.Actors.Remove(existedactor);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        public async Task<IActionResult> Detail(int id)
        {
            Actor actor = await _context.Actors.FirstOrDefaultAsync(s => s.Id == id);
            return View(actor);
        }

    }
}
