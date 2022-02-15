using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace OnlineStore.ViewsModel.ColorViewModels
{
    public class ColorViewModel
    {
        [MaxLength(20)]
        [Required]
        public string Name { get; set; }

        public int ColorId { get; set; }

        [Required]
        public string HexValue { get; set; }
    }
}
