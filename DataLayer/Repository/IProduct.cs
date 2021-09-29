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
        Task AddProduct(Product product);

        Task<IList<Product>> GetProductByCategoryId(int id);

        Task<Product> GetProductById(int id);

        Task<IList<Product>> GetPopularProducts();
    }
}
