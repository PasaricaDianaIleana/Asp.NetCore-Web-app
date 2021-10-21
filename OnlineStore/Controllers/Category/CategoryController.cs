using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers.Category
{
    public class CategoryController : Controller
    {
        private readonly ICategory _repo;

        public CategoryController(ICategory repo)
        {
            _repo = repo;
        }

       
        [HttpPost]
        public async Task<IActionResult> AddCategory(CategoryViewModel model)
        {
            return Ok();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = (await _repo.GetAll())
                .Select(Category => new CategoryViewModel
                {
                    CategoryName = Category.Name,
                    CategoryId = Category.CategoryId
                });

            return View(categories);
        }
    }
}
