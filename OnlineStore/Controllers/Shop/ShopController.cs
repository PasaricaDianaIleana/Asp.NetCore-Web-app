using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataLayer.Models;

namespace OnlineStore.Controllers.Category
{
    public class ShopController : Controller
    {
        private readonly ICategory _repo;
        private readonly IProduct _repository;

        public ShopController(ICategory repo,IProduct repository)
        {
            _repo = repo;
            _repository = repository;
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
        
        public async Task<ActionResult<IList<Product>>>Products(int id)
        {
            var products = (await _repository.GetProductByCategoryId(id)).Select(prod=>new ProductsViewModel {
            Name=prod.Name,
            Price=prod.Prices.SingleOrDefault(p=>p.Active==true),
            Description=prod.Description,
            Photo=prod.ProductPhoto.FirstOrDefault()

            });
            var model = new ShopViewListModel
            {
                products = products
            };
            return View(model);
        }
    }
}
