using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFarmer.Domain.Interfaces
{
    public interface IAnimalRepository
    {
        Task Create(Domain.Entities.Animall animall);
    
    }
}
