using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFarmer.Application.Servises;

namespace WebFarmer.Application.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddApplication(this IServiceCollection sevices)
        {
            sevices.AddScoped<IAnimalService, AnimalService>();       
        }
    }
}
