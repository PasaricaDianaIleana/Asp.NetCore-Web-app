using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using OnlineStore.ViewsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class ProductsController : Controller
    {
        private readonly ICategory _repo;
        private readonly IProduct _repository;

        public ProductsController(ICategory repo, IProduct repository)
        {
            _repo = repo;
            _repository = repository;
        }
        public IActionResult Index()
        {
            return View();
        }

        public async Task<ActionResult<IList<Product>>> Products(int id)
        {
            var products = (await _repository.GetProductByCategoryId(id)).Select(prod => new ProductsViewModel
            {
                Name = prod.Name,
                Price = prod.Prices.SingleOrDefault(p => p.Active == true),
                Description = prod.Description,
                Photo = prod.ProductPhoto.FirstOrDefault()

            });
            var model = new ShopViewListModel
            {
                products = products
            };
            return View(model);
        }


    }
}
