using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class HomeController : Controller
    {
        private readonly IProduct _repo;

        public ICategory _repository;

        public HomeController(IProduct repo,ICategory repository)
        {
            _repo = repo;
            _repository = repository;
        }
        public async Task<IActionResult> Index()
        {
            var productList = (await _repo.GetAllProducts())
                .Select(products => new ProductsViewModel
                {
                    Description = products.Description,
                    Name = products.Name,
                    Price = products.Prices.SingleOrDefault(pr => pr.Active == true),
                    Photo = products.ProductPhoto.FirstOrDefault()

                });
            var categories = (await _repository.GetAll())
                .Select(category => new CategoryViewModel
                {
                    CategoryName=category.Name,
                    CategoryId=category.CategoryId,
                    Image=category.Image
                });
            var model = new HomeViewModel
            {
                categories = categories,
                products = productList
            }; 
            return View(model);
        }
    }
}
