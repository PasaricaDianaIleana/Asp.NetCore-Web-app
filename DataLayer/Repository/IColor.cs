using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Repository
{
     public interface IColor
    {
        Task<IList<Color>> GetAllColors();
        Task Delete(int id);
        Task AddColor(Color color);

        Task<Color> GetColorById(int id);
        Task<Color> EditColor(Color model);

    }
}
