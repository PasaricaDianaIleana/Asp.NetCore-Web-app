using DataLayer.Models;
using DataLayer.Repository;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineShop_Service.Repository
{
    public class ProductsService : IProduct
    {
        private readonly StoreDbContext _context;

        public ProductsService(StoreDbContext context)
        {
            _context = context;
        }
     public async Task AddProduct(Product product)
        {
            await _context.Products.AddAsync(product);
           await  _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var product = await GetProductById(id);
            _context.Products.Remove(product);
           await  _context.SaveChangesAsync();

        }

        public async Task<IList<Product>> GetAllProducts()
        {
            return await _context.Products
                .Include(p=>p.ProductPhoto)
                .Include(p=>p.ProductOptions)
                .ThenInclude(p=>p.Color)
                .Include(p=>p.ProductOptions)
                .ThenInclude(p=>p.Size)
                .Include(p=>p.Raitings)
                .Include(p=>p.Prices).
                ToListAsync();
        }

        public async Task<IList<Product>> GetPopularProducts()
        {
            return (await GetAllProducts()).Take(10).OrderBy(p => p.Raitings).ToList();
                }

        public async Task<IList<Product>> GetProductByCategoryId(int id)
        {
            return await _context.Products.Where(c => c.CategoryId == id).ToListAsync();
        }

        public async Task<Product> GetProductById(int id)
        {
            return await _context.Products.Where(p => p.ProductId == id).FirstOrDefaultAsync();
        }
    }
}
