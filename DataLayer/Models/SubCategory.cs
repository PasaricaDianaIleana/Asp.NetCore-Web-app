﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class SubCategory
    {

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public byte Subcategory_id { get; set; }
        [MaxLength(50)]
        [Required]
        public String Name { get; set; }

       public IList<Product> Product { get; set; }
    }
}
