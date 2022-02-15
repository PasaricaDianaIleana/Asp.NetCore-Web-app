using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.ViewsModel.ColorViewModels;
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
        
        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var colors= (await _repo.GetAllColors())
                .Select(Color=> new ColorViewModel
                {
                    Name=Color.Name,
                    HexValue=Color.HexValue
                }).ToList();
            return View(colors);
        }
    }
}
