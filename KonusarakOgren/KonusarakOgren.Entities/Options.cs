using KonusarakOgren.Entities.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities
{
   public class Options:BaseEntity
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public ICollection<Product> Products { get; set; }              
        public ICollection<Discount> Discounts { get; set; }

    }
}
