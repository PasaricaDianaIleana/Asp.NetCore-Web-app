using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers.Colors
{
    public class ColorsController : Controller
    {
        private readonly IColor _repo;

        public ColorsController(IColor repo)
        {
            _repo = repo;
        }
        
        public IActionResult Index()
        {
            return View();
        }
    }
}
