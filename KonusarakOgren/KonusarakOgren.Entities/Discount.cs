using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities
{
    public class Discount:BaseEntity
    {
        public Options Options { get; set; }
        public decimal DiscountRate { get; set; }

    }
}
