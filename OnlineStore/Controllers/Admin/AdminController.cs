using DataLayer.Repository;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        private readonly ICategory _repo;
        private readonly IProduct _repository;

        public AdminController(ICategory repo,IProduct repository)
        {
            _repo = repo;
            _repository = repository;
        }
        
        public IActionResult Index()
        {
            return View();
        }
       
    }
}
