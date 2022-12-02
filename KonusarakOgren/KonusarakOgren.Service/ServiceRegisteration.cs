using KonusarakOgren.Application.Repositories;
using KonusarakOgren.Application.Service;
using KonusarakOgren.Service.Repositories;
using KonusarakOgren.Service.Service;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.Service
{
    public static class ServiceRegisteration
    {
        public static void AddServiceRegister(this IServiceCollection service)
        {
            service.AddScoped<IProductRepository, ProductRepository>();
            service.AddScoped<IProductService, ProductService>();
            service.AddScoped<IUserService, UserService>();
        }
    }
}
