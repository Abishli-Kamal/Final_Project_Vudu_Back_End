using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vudu.com_Back_End.DAL;
using Vudu.com_Back_End.Models;
using Vudu.com_Back_End.Utilities;
using Vudu.com_Back_End.View_models;

namespace Vudu.com_Back_End.Controllers
{
    public class AccountController : Controller
    {
        private readonly AppDbContext _context;
        private readonly UserManager<AppUser> _usermanager;
        private readonly SignInManager<AppUser> _signInManager;
        private readonly RoleManager<IdentityRole> _roleManager;

        public AccountController(AppDbContext context, UserManager<AppUser> usermanager, SignInManager<AppUser> signInManager, RoleManager<IdentityRole> roleManager)
        {
            _context=context;
            _usermanager = usermanager;
            _signInManager = signInManager;
            _roleManager = roleManager;
        }
        public IActionResult Register()
        {

            return View();
        }

        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Register(RegisterVM registerVm)
        {
            if (!ModelState.IsValid) return View();

            AppUser user = new AppUser
            {

                Firstname = registerVm.Firstname,
                Lastname = registerVm.Lastname,
                Email = registerVm.Email,
                UserName = registerVm.Username
            };
            if (registerVm.IHaveReadIAccept == true)
            {
                IdentityResult result = await _usermanager.CreateAsync(user, registerVm.Password);
                if (!result.Succeeded)
                {

                    foreach (IdentityError error in result.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }

                    return View();
                }

            }
            else
            {
                ModelState.AddModelError("", "You must accept the terms");
                return View();

            }
            await _usermanager.AddToRoleAsync(user, Role.Member.ToString());

            await _signInManager.SignInAsync(user, false);

            return RedirectToAction("Index", "Home");
        }
        public async Task CreateRole()
        {
            await _roleManager.CreateAsync(new IdentityRole { Name = Role.Member.ToString() });
            await _roleManager.CreateAsync(new IdentityRole { Name = Role.Admin.ToString() });
            await _roleManager.CreateAsync(new IdentityRole { Name = Role.SuperAdmin.ToString() });
        }

        public IActionResult Login()
        {

            return View();
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]

        public async Task<IActionResult> Login(LoginVM login)
        {
            AppUser user = await _usermanager.FindByNameAsync(login.Username);
            if (user == null) return View();
            IList<string> roles = await _usermanager.GetRolesAsync(user);
            string role = roles.FirstOrDefault(r => r == Role.Member.ToString());
            if (role == null)
            {
                ModelState.AddModelError("", "Please contact with admins");
                return View();
            }
            else
            {
                if (login.RememberMe)
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, login.Password, true, true);

                    if (!result.Succeeded)
                    {
                        if (result.IsLockedOut)
                        {
                            ModelState.AddModelError("", "You have been dismissed for 5 minutes");
                            return View();
                        }
                        else
                        {

                        }
                        {
                            ModelState.AddModelError("", "Username or Password is incorrect");
                            return View();

                        }

                    }
                }
                else
                {
                    Microsoft.AspNetCore.Identity.SignInResult result = await _signInManager.PasswordSignInAsync(user, login.Password, false, true);

                    if (!result.Succeeded)
                    {
                        if (result.IsLockedOut)
                        {
                            ModelState.AddModelError("", "You have been dismissed for 5 minutes");
                            return View();
                        }

                        ModelState.AddModelError("", "Username or Password is incorrect");
                        return View();

                    }
                }
                return RedirectToAction("Index", "Home");
            }


        }
        public async Task<IActionResult> Logout()
        {
            await _signInManager.SignOutAsync();
            return RedirectToAction("Index", "Home");
        }
        [Authorize]
        public async Task<IActionResult> Edit()
        {
            AppUser user = await _usermanager.FindByNameAsync(User.Identity.Name);
            if (user == null) return NotFound();

            EditUserVM edit = new EditUserVM
            {
                Firstname = user.Firstname,
                Lastname = user.Lastname,
                Email = user.Email,
                Username = user.UserName,

            };
            return View(edit);
        }
        [HttpPost]
        [AutoValidateAntiforgeryToken]
        public async Task<IActionResult> Edit(EditUserVM user)
        {
            AppUser existeduser = await _usermanager.FindByNameAsync(User.Identity.Name);
            bool result = user.NewPassword == null && user.NewConfirmPassword == null && user.CurrenPassword != null;
            EditUserVM edit = new EditUserVM
            {
                Firstname = existeduser.Firstname,
                Lastname = existeduser.Lastname,
                Email = existeduser.Email,
                Username = existeduser.UserName,

            };
            if (!ModelState.IsValid) return View(edit);
            if (user.Email == null && existeduser.Email != null)
            {
                ModelState.AddModelError("", "You can not change your email");
                return View(edit);
            }

            if (result)
            {
                existeduser.Firstname = user.Firstname;
                existeduser.Lastname = user.Lastname;
                existeduser.UserName = user.Username;
                await _usermanager.UpdateAsync(existeduser);

            }
            else
            {
                existeduser.Firstname = user.Firstname;
                existeduser.Lastname = user.Lastname;
                existeduser.UserName = user.Username;

                if (user.CurrenPassword == user.NewPassword)
                {
                    ModelState.AddModelError("", "You can not change password with the same password ");
                    return View();
                }
                IdentityResult resultedit = await _usermanager.ChangePasswordAsync(existeduser, user.CurrenPassword, user.NewPassword);

                if (!resultedit.Succeeded)
                {
                    foreach (IdentityError error in resultedit.Errors)
                    {
                        ModelState.AddModelError("", error.Description);
                    }
                    return View(edit);
                }
            }

            return RedirectToAction("Index", "Home");
        }
    }
}
