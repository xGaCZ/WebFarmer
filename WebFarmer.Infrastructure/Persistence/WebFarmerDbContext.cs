using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFarmer.Infrastructure.Persistence
{
    public class WebFarmerDbContext : DbContext
    {
        public WebFarmerDbContext(DbContextOptions<WebFarmerDbContext> options) : base(options)
        {

        }
        public DbSet<Domain.Entities.WebFarmer> WebFarmers { get; set; }
    }
}
