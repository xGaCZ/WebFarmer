using WebFarmer.Domain.Entities;

namespace WebFarmer.Application.Servises
{
    public interface IAnimalService
    {
        Task Create(Animall animall);
    }
}