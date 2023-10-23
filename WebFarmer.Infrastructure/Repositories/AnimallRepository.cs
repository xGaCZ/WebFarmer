using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFarmer.Domain.Interfaces;
using WebFarmer.Infrastructure.Persistence;

namespace WebFarmer.Infrastructure.Repositories
{
    internal class AnimallRepository : IAnimalRepository
    {
        private readonly WebFarmerDbContext _dbContext;
        public AnimallRepository(WebFarmerDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public async Task Create(Domain.Entities.Animall animall)
        {
            _dbContext.Add(animall);
          await _dbContext.SaveChangesAsync();

        }
    }
}
