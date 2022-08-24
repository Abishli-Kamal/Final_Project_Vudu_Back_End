﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    public class RatingController : Controller
    {
        private readonly AppDbContext _context;

        public RatingController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index()
        {

            
            List<Rating> rt = await _context.Ratings.ToListAsync();
            return View(rt);
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Create(Rating rt)
        {
            if (!ModelState.IsValid) return View();

            await _context.AddAsync(rt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Edit(int id)
        {
            Rating rt = await _context.Ratings.FirstOrDefaultAsync(s => s.Id==id);
            return View(rt);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(Rating rt, int id)
        {
            if (!ModelState.IsValid) return View();
            Rating existedrt = await _context.Ratings.FirstOrDefaultAsync(s => s.Id==id);
            if (rt.Id!=existedrt.Id) return BadRequest();
            existedrt.Name=rt.Name;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Delete(int id)
        {
            Rating rt = await _context.Ratings.FirstOrDefaultAsync(s => s.Id==id);
            return View(rt);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        [ActionName("Delete")]
        public async Task<IActionResult> DeleteRating(Rating rt)
        {
            if (!ModelState.IsValid) return View();
            _context.Remove(rt);
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }
        public async Task<IActionResult> Detail(int id)
        {
            Rating rt = await _context.Ratings.FirstOrDefaultAsync(s => s.Id==id);
            return View(rt);
        }
    }
}
