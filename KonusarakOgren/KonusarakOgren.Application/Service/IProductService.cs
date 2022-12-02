using KonusarakOgren.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Application.Service
{
    public interface IProductService
    {
        Task AddAsync(Product product);
        Task UpdateAsync(Product product);
        Task DeleteAsync(string id);
        IList<Product> GetProducts();
        Task<Product> GetById(string id);
        
    }
}
