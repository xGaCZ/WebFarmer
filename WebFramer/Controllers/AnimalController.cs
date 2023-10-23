using Microsoft.AspNetCore.Mvc;
using WebFarmer.Application.Servises;

namespace WebFarmer.Controllers
{
    public class AnimalController :Controller
    {
        private readonly IAnimalService _animalService;
        public  AnimalController(IAnimalService animalService)
        {
            _animalService = animalService;
        }

        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public async Task<IActionResult> Create(Domain.Entities.Animall animall) 
        {
          await  _animalService.Create(animall);
            return RedirectToAction(nameof(Create));
        }
    }
}
