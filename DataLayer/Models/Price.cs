using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Price
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Price_Id { get; set; }
        public double Net_Price { get; set; }
        public double Discount { get; set; }
        [Required]
        public bool Active { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
