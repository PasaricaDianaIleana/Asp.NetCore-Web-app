using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class ProductOptions
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductOption_Id { get; set; }
        public int ProductId { get; set; }
        public int? SizeId { get; set; }
        public int? ColorId { get; set; }
        public int Quantity { get; set; }
        public Product Product { get; set; }
        public Size Size { get; set; }
        public Color Color { get; set; }
    }
}
