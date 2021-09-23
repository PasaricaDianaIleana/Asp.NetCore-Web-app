using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
   public class FooterMenu
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int FooterItem_Id { get; set; }
        [Required]
        [MaxLength(50)]
        public string Link { get; set; }
        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
    }

}
