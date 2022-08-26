using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using Vudu.com_Back_End.Areas.VuduAdmin.View_Models;
using Vudu.com_Back_End.DAL;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area("VuduAdmin")]
    [Authorize(Roles = "SuperAdmin,Admin")]
    public class DashboardController : Controller
    {
        private readonly AppDbContext _context;

        public DashboardController(AppDbContext context)
        {
            _context=context;
        }
     
        public async Task<IActionResult> Index()
        {
            AdminChartVM chartVM = new AdminChartVM
            {
                AppUsers= await _context.AppUsers.ToListAsync(),
                Movies=await _context.Movies.ToListAsync()
            };
           
            return View(chartVM);
        }
    }
}
