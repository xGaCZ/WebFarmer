using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WebFarmer.Infrastructure.Persistence;
using Microsoft.Extensions.Configuration;
using WebFarmer.Infrastructure.Seeders;
using WebFarmer.Domain.Interfaces;

namespace WebFarmer.Infrastructure.Extensions
{
    public static class ServiceCollectionExtension
    {
        public static void AddInfrastructure(this IServiceCollection sevices, IConfiguration configuration ) 
        {
            sevices.AddDbContext<WebFarmerDbContext>(options => options.UseSqlServer(configuration.GetConnectionString("WebFarmer")));
            sevices.AddScoped<WebFarmerSeeder>();
            sevices.AddScoped<IAnimalRepository, IAnimalRepository>();
        }   
    }
}
