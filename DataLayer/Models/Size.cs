using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DataLayer.Models
{
    public class Size
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Sizeid { get; set; }
        [MaxLength(10)]
        [Required]
        public String Name { get; set; }
        public IList<ProductOptions> ProductOption { get; set; }
    }
}
