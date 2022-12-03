using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities
{
    public class Order:BaseEntity
    {
        public Basket Basket { get; set; }
        public string OrderStatus { get; set; }
        public bool IsComplete { get; set; }
        public DateTime OrderCreateDate { get; set; }
        public DateTime OrderUpdateDate { get; set; }
        public ICollection<Payment> Payments { get; set; }
        
    }
}
