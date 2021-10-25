using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewsModel.CategoryViewModels
{
    public class CategoryViewModel
    {
        [Required]
        [MaxLength(50, ErrorMessage ="Category name cannot exceed  50 characters")]
        public string CategoryName { get; set; }
        public int CategoryId { get; set; }
        [Required]

        public string Image { get; set; }
    }
}
