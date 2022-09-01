using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vudu.com_Back_End.Areas.VuduAdmin.View_Models;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;

namespace Vudu.com_Back_End.Areas.VuduAdmin.Controllers
{
    [Area ("VuduAdmin")]
    //[Authorize(Roles = "Admin,SuperAdmin")]

    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly RoleManager<IdentityRole> _roleManager;
        private readonly SignInManager<AppUser> _sigInManager;
        private readonly UserManager<AppUser> _userManager;

        public AccountController(AppDbContext context, RoleManager<IdentityRole> roleManager, SignInManager<AppUser> sigInManager,UserManager<AppUser> userManager)
        {
            _context=context;
            _roleManager=roleManager;
            _sigInManager=sigInManager;
            _userManager=userManager;
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
                existerUser.IsBlock = false;
            }
            else if (user.IsBlock==false)
            {
                existerUser.IsBlock=true;
            }


            if (user.IsAdmin==true)
            {
                existerUser.IsAdmin = false;
            }
           
            existerUser.IsAdmin=user.IsAdmin;
            existerUser.IsBlock = user.IsBlock;
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));

        }


        [AllowAnonymous]
        public IActionResult Login()
        {
            return View();
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        [AllowAnonymous]
        public async Task<IActionResult> Login(AdminLoginViewModel adminLogin)
        {
            if (!ModelState.IsValid)
            {
                return View();
            }
            AppUser admin = await _userManager.Users.FirstOrDefaultAsync(x => x.NormalizedUserName == adminLogin.Username.ToUpper() && x.IsAdmin==true);
            if (admin==null)
            {
                ModelState.AddModelError("", "Username or password is incorrect");
                return View();
            }
            if (admin.IsAdmin==true)
            {
                var result = await _sigInManager.PasswordSignInAsync(admin, adminLogin.Password, false, false);
                if (!result.Succeeded)
                {
                    ModelState.AddModelError("", "Username or password is incorrect");
                    return View();
                }

              
            }
            return RedirectToAction("index", "dashboard");
        }

          public async Task<IActionResult> Logout()
        {

            await _sigInManager.SignOutAsync();
            return RedirectToAction("login","account");
        }

        public async Task<IActionResult> CreateSuperAdmin()
        {
            AppUser superadmin = new AppUser
            {
                UserName = "Kamal",
                IsAdmin = true,
                Email = "malik.seferov8008@gmail.com",
                PhoneNumber = "0507312011"
            };

            var result = await _userManager.CreateAsync(superadmin, "Admin123!");
            await _userManager.AddToRoleAsync(superadmin, "SuperAdmin");
            return Ok(result);
        }

        public async Task CreateRole()
        {
            await _roleManager.CreateAsync(new IdentityRole("SuperAdmin"));
            await _roleManager.CreateAsync(new IdentityRole("Admin"));
            await _roleManager.CreateAsync(new IdentityRole("Member"));
        }
    }


}
