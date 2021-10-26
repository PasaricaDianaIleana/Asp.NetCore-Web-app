using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
   public interface ICategory
    {
        Task<Category> GetCategoryById(int id);
        Task<IList<Category>> GetAll();
        Task Add(Category category);
        Task Delete(Color color);

    }
}
