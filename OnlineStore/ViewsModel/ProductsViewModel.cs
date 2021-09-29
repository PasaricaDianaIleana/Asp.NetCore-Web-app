using DataLayer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewsModel
{
    public class ProductsViewModel
    {
        public int ProductId { get; set; }
        public string Name { get; set; }
        public virtual string Description { get; set; }
        public ProductPhoto Photo { get; set; }
        public Price Price { get; set; }
    }
}
