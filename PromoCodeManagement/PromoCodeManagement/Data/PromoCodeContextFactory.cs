using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace PromoCodeManagement.Data
{
    public class PromoCodeContextFactory: IDesignTimeDbContextFactory<PromoCodeContext>
    {
        public PromoCodeContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
              .SetBasePath(Directory.GetCurrentDirectory())
              .AddJsonFile("appsettings.json")
              .Build();

            return new PromoCodeContext(new DbContextOptionsBuilder<PromoCodeContext>().Options, config);
        }
    }
}
