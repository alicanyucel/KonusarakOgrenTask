using KonusarakOgren.Entities;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KonusarakOgren.DataAccess.Context
{
    public class KonusarakOgrenContext:IdentityDbContext<AppUser,AppRole,string>
    {
        public KonusarakOgrenContext(DbContextOptions options ) :base(options)
        {

        }
        public DbSet<Product>Products { get; set; }
        public DbSet<Options> Options { get; set; }
        public DbSet<Discount> Discounts { get; set; }
        public DbSet<Comment> Comments { get; set; }



    }
}
