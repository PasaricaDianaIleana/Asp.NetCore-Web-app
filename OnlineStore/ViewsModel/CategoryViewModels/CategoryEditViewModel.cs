using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewsModel.CategoryViewModels
{
    public class CategoryEditViewModel:CreateCategoryViewModel
    {
        public int CategoryId { get; set; }
        public string ExistingPhotoPath { get; set; }
    }
}
