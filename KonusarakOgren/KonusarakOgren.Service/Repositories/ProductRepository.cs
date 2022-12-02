using KonusarakOgren.Application.Repositories;
using KonusarakOgren.DataAccess.Context;
using KonusarakOgren.Entities;
using KonusarakOgren.Service.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Service.Repositories
{
   public class ProductRepository:Repository<Product>,IProductRepository
    {
        public ProductRepository(KonusarakOgrenContext context):base(context)
        {

        }
    }
}
