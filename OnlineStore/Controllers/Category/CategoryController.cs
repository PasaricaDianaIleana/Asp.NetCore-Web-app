using DataLayer.Repository;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Hosting;
using OnlineStore.ViewsModel;
using OnlineStore.ViewsModel.CategoryViewModels;
using System;
using DataLayer.Models;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.Controllers
{
    public class CategoryController : Controller
    {
        private readonly ICategory _repo;
        private readonly IHostEnvironment _env;

        public CategoryController(ICategory repo,IHostEnvironment env)
        {
            _repo = repo;
            _env = env;
        }

        [HttpGet]
        public IActionResult AddCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> AddCategory(CreateCategoryViewModel model)
        {
            if (ModelState.IsValid)
            {
                string uniqueFileName = null;
                if (model.Image != null)
                {
                   string uploadFile= Path.Combine(_env.ContentRootPath, "wwwroot\\images");
                    uniqueFileName= Guid.NewGuid().ToString() + "_" + model.Image.FileName;
                   string filePath= Path.Combine(uploadFile, uniqueFileName);
                    model.Image.CopyTo(new FileStream(filePath, FileMode.Create));

                }
                Category newCategory = new Category
                {
                    Name = model.CategoryName,
                    Image="images/"+uniqueFileName
                };
               await _repo.Add(newCategory);
                return RedirectToAction("Index", new { id = newCategory.CategoryId});
            }
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var categories = (await _repo.GetAll())
                .Select(Category => new CategoryViewModel
                {
                    CategoryName = Category.Name,
                    CategoryId = Category.CategoryId,
                    Image=Category.Image
                }).ToList();

            return View(categories);
        }
       [HttpGet]
       public async Task<IActionResult> EditCategory(int id)
        {
            Category category = await _repo.GetCategoryById(id);
            var categoryEditView = new CategoryEditViewModel
            {
                CategoryId = category.CategoryId,
                CategoryName=category.Name,
                ExistingPhotoPath=category.Image
            };

            return View(categoryEditView);
        }
      
    }
}
