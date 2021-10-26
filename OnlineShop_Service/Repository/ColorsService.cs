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
   public class ColorsService:IColor
    {
        private readonly StoreDbContext _context;

        public ColorsService(StoreDbContext context)
        {
            _context = context;
        }

        public async Task AddColor(Color color)
        {
          await  _context.Colors.AddAsync(color);
           await _context.SaveChangesAsync();
        }

        public async Task Delete(int id)
        {
            var color = await GetColorById(id);
            if (color != null)
            {
                _context.Colors.Remove(color);
               await  _context.SaveChangesAsync();
            }
     
        }

        public async Task<Color> EditColor(Color model)
        {
            var color = await GetColorById(model.ColorId);
            if (color != null)
            {
                color.Name = model.Name;
                await _context.SaveChangesAsync();
                return color;
            }
            return null;
        }

        public async Task<IList<Color>> GetAllColors()
        {
            return await _context.Colors.ToListAsync();
        }

        public async Task<Color> GetColorById(int id)
        {
            return await _context.Colors.Where(c => c.ColorId == id).FirstOrDefaultAsync();
        }
    }
}
