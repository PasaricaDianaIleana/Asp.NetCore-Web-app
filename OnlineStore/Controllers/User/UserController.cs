using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers.User
{
    public class UserController : Controller
    {

        public IActionResult Login()
        {
            return View();
        }
        public IActionResult Register()
        {
            return View();
        }
    }
}
