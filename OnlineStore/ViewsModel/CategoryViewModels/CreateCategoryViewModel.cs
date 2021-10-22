using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace OnlineStore.ViewsModel.CategoryViewModels
{
    public class CreateCategoryViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage = "Category name cannot exceed  50 characters")]
        public string CategoryName { get; set; }
        [Required]
        public IFormFile Image { get; set; }
    }
}
