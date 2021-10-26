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
    public class CategoriesService : ICategory
    {
        private readonly StoreDbContext _context;

        public CategoriesService(StoreDbContext context)
        {
            _context = context;
        }
        public async Task  Add(Category category)
        {
            await _context.Categories.AddAsync(category);
             await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var category = await GetCategoryById(id);
            _context.Categories.Remove(category);
            await _context.SaveChangesAsync();
        }

        public Task Delete(Color color)
        {
            throw new NotImplementedException();
        }

        public async Task<IList<Category>> GetAll()
        {
            return await _context.Categories.ToListAsync();
        }

        public async Task<Category> GetCategoryById(int id)
        {
            return await _context.Categories.Where(C => C.CategoryId == id).FirstOrDefaultAsync();
        }
    }
}
