using DataLayer.Models;
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
        [HttpGet]
        public IActionResult AddColor()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> AddColor(CreateColorViewModel colorView)
        {
            if (ModelState.IsValid)
            {
                Color color = new Color
                {
                    Name= colorView.ColorName,
                    HexValue = colorView.HexValue
                }; 
               await _repo.AddColor(color);
                return RedirectToAction("Index", new { id = color.ColorId });
            }
            return View();
        }
    }
}
