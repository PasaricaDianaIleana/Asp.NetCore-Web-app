using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
      [MaxLength(400)]
      [Required]
        public string Description { get; set; }

      public int SubCategory_Id { get; set; }
        public int CategoryId { get; set; }
        public int Type_Id { get; set; }
        public Category Category { get; set; }
        public SubCategory SubCategory { get; set; }
        public ProductType Type { get; set; }
        public IList<Raiting> Raitings { get; set; }
        public IList<Price> Prices { get; set; }
        public IList<ProductOptions> ProductOptions { get; set; }
        public IList<ProductPhoto> ProductPhoto { get; set; }
    }
}
