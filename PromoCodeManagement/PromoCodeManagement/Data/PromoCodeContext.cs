using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using PromoCodeManagement.Data.Enteties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PromoCodeManagement.Data
{
    public class PromoCodeContext : DbContext
    {
        private readonly IConfiguration _config;

        public PromoCodeContext(DbContextOptions options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public DbSet<PromoCode> PromoCodes { get; set; }
      

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("PromoCodeDB"));
        }

        protected override void OnModelCreating(ModelBuilder bldr)
        {
            bldr.Entity<PromoCode>()
              .HasData(new
              {
                  PromoId = 1,
                  Code = "ATL2018"
                 
              }
              );

           

        }
    }
}
