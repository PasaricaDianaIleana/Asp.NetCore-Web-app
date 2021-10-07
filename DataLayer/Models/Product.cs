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
        public virtual string Description { get; set; }
        [ForeignKey("SubCategory")]
        public virtual int SubCategory_Id { get; set; }
        [ForeignKey("Category")]
        public virtual int CategoryId { get; set; }
        [ForeignKey("Type")]
        public virtual int Type_Id { get; set; }
        public virtual Category Category { get; set; }
        public virtual SubCategory SubCategory { get; set; }
        public virtual ProductType Type { get; set; }
        public virtual IList<Raiting> Raitings { get; set; }
        public virtual IList<Price> Prices { get; set; }
        public virtual IList<ProductOptions> ProductOptions { get; set; }
        public virtual IList<ProductPhoto> ProductPhoto { get; set; }
    }
}
