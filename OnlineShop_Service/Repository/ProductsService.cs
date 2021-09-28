using DataLayer.Models;
using DataLayer.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop_Service.Repository
{
    public class ProductsService : IProduct
    {
        public Task<Product> AddProduct(Product product)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public Task<IList<Product>> GetAllProducts()
        {
            throw new NotImplementedException();
        }
    }
}
