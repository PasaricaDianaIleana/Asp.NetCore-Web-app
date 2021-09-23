using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataLayer.Models
{
  public  class Order
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int OrderId { get; set; }
        public DateTime Time { get; set; }
        [Required]
        public string UserId { get; set; }

        public User User { get; set; }
        public IList<ItemOrder> ItemOrders { get; set; }
    }
}
