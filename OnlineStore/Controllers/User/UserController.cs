using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;
namespace OnlineStore.Controllers
{
    public class UserController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        public UserController(UserManager<User> userManager,SignInManager<User> signInManager)
        {
            _userManager = userManager;
            _signInManager = signInManager;
        }
        [HttpGet]
        public IActionResult Login()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Register()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Register(RegisterViewModel model)
        {
            if (ModelState.IsValid)
            {
                var checkUser = await _userManager.FindByEmailAsync(model.Email);
                if (checkUser != null)
                {
                    return BadRequest();
                }
                var user = new User
                {
                   
                    FirstName=model.FirstName,
                    LastName=model.LastName,
                    Email = model.Email,
                    Country=model.Country,
                    PhoneNumber=model.PhoneNumber,

                };
            var result= await   _userManager.CreateAsync(user, model.Password);
                if (result.Succeeded)
                {
                 
                    return RedirectToAction("index", "home");
                }
                
            }
           
            return View(model);
        }
    }
}
