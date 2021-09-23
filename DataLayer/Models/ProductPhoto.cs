using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class ProductPhoto
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ImageId { get; set; }
        [Required]
        public string Soruce { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
    }
}
