using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace OnlineStore.Controllers
{
    [Authorize]
    public class AdminController : Controller
    {
        
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult CreateProduct()
        {
            return View();
        }
        [HttpGet]
        public IActionResult AddPromotion()
        {
            return View();
        }
    }
}
