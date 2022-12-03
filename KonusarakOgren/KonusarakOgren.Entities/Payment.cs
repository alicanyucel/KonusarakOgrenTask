using System;
using KonusarakOgren.Entities.Abstract;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Entities
{
   public class Payment:BaseEntity
    {
        public Order Order { get; set; }
        public string NameLastName { get; set; }
        public string CreateCartNumber { get; set; }
        public string ExpireDate { get; set; }
        public string Cvv { get; set; }
        public DateTime CreateDate { get; set; }
        public bool IsPaymentSuccess { get; set; }
    }
}
