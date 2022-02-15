using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public  class Color
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ColorId { get; set; }
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        [Required]
        public string HexValue { get; set; }
        public IList<ProductOptions> ProductOptions { get; set; }
    }
}
