using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers.Category
{
    public class ShopController : Controller
    {
        private readonly ICategory _repo;

        public ShopController(ICategory repo)
        {
            _repo = repo;
        }
        public async Task<IActionResult> Index()
        {
            var categories =( await _repo.GetAll())
                .Select(Category => new CategoryViewModel
                {
                    CategoryName=Category.Name,
                    CategoryId=Category.CategoryId
                });
           
            return View(categories);
        }
    }
}
