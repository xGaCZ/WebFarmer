using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFarmer.Infrastructure.Persistence;

namespace WebFarmer.Infrastructure.Seeders
{
    public class WebFarmerSeeder
    {
        private readonly WebFarmerDbContext _dbContext;
        public WebFarmerSeeder(WebFarmerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Seed()
        {
            if(await _dbContext.Database.CanConnectAsync())
            { 
                if(!_dbContext.WebFarmers.Any())
                {
                    var gracz = new Domain.Entities.WebFarmer()
                    {
                        Name = "Daro",
                        Cash = 1520
                    };
                    _dbContext.WebFarmers.Add(gracz);
                    await _dbContext.SaveChangesAsync();
                }
            }
        }
    }
}
