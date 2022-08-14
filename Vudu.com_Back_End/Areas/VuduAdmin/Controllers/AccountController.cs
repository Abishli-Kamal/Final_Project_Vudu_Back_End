using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area ("VuduAdmin")]

    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly SignInManager<AppUser> _sigInManager;

        public AccountController(AppDbContext context, SignInManager<AppUser> sigInManager)
        {
            _context=context;
            _sigInManager=sigInManager;
        }
        public async Task<IActionResult> Index()
        {
            List<AppUser> user = await _context.AppUsers.ToListAsync();
            return View(user);
        }

        public async Task<IActionResult> Edit(string id)
        {
            AppUser user = await _context.AppUsers.FindAsync(id);
            return View(user);
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(AppUser user)
        {
            if (!ModelState.IsValid) return View();

            AppUser existerUser = await _context.AppUsers.FirstOrDefaultAsync(s => s.Id == user.Id);
            if (existerUser == null) return NotFound();

            existerUser.Firstname = user.Firstname;
            existerUser.Lastname = user.Lastname;

            if (user.IsBlock==true)
            {
                await _sigInManager.SignOutAsync();
                existerUser.IsBlock = false;
            }
            else if (user.IsBlock==false)
            {
                existerUser.IsBlock=true;
            }

            existerUser.IsBlock = user.IsBlock;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));


        }
    }
}
