using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Raiting
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int RaintingId { get; set; }
        [Required]
        public int ProductId { get; set; }
        [Required]
        public string UserId { get; set; }
        [Required]
        public int Value { get; set; }
        public Product Product { get; set; }
        public User User { get; set; }
    }
}
