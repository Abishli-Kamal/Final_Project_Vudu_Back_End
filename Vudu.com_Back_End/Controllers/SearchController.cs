using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;
using Vudu.com_Back_End.View_models;

namespace Vudu.com_Back_End.Controllers
{
    public class SearchController : Controller
    {
        private readonly AppDbContext _context;

        public SearchController(AppDbContext context)
        {
            _context=context;
        }
        public async Task<IActionResult> Index(string search)
        {
            ViewBag.Serach=search;
            List<Movie> movies = await _context.Movies.Where(m => m.Name.Contains(search)).ToListAsync();
            List<MainOption> mainOption= await _context.MainOptions.ToListAsync();
            List<SubOptionTitle> sub = await _context.SubOptionTitles.ToListAsync();
            List<SubOptionImage> subOptionImages = await _context.SubOptionImages.ToListAsync();
            List<SubOptionSubTitle> subOptionSubTitles = await _context.SubOptionSubTitles.ToListAsync();
          

            HomeVM model = new HomeVM
            {
                Movies=movies,
                SubOptionTitles=sub,
                SubOptionImages=subOptionImages,
                SubOptionSubTitles=subOptionSubTitles,
                MainOptions=mainOption,
            };
            return View(model);
        }
    }
}
