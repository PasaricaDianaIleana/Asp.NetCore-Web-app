using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class StoreDbContext:IdentityDbContext<User,Role,String>
    {
        public StoreDbContext(DbContextOptions<StoreDbContext>options):base(options)
        {

        }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<FooterMenu> FooterMenus { get; set; }
     
        public DbSet<Order> Orders { get; set; }
        public DbSet<ItemOrder> ItemOrders { get; set; }
     
        public DbSet<Price> Prices { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<ProductPhoto> ProductPhotos { get; set; }
        public DbSet<ProductOptions> ProductOptions { get; set; }
        public DbSet<Raiting> Ratings { get; set; }
        public DbSet<Size> Sizes { get; set; }

        public DbSet<SubCategory> Subcategories { get; set; }
        public DbSet<ProductType> Types { get; set; }
       

    }
}
