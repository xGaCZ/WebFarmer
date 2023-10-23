using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFarmer.Domain.Interfaces;

namespace WebFarmer.Application.Servises
{
    public class AnimalService : IAnimalService
    {


        private readonly IAnimalRepository _animalRepository;
        public AnimalService(IAnimalRepository animalRepository)
        {
            _animalRepository = animalRepository;
        }

        public async Task Create(Domain.Entities.Animall animall)
        {
            await _animalRepository.Create(animall);
        }
    }
}
