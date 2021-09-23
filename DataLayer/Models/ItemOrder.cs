using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
    public class ItemOrder
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ItemOrder_Id { get; set; }
        public int ProductOptionsId  { get; set; }
        public int OrderId { get; set; }
        public int Amount { get; set; }
        public ProductOptions ProductOption { get; set; }
        public Order Order { get; set; }
    }
}
