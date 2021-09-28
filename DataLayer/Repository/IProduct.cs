using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
    public interface IProduct
    {
        Task<IList<Product>> GetAllProducts();

        Task Delete(int id);
        Task<Product> AddProduct(Product product);

        Task<Product> GetProductByCategoryId(int id);

        
    }
}
