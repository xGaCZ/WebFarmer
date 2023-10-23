using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFarmer.Domain.Entities
{
   public class Animall
    {
        public int Id { get; set; }
        public string AnimalName { get; set; } = default!;
        public string AnimalType { get; set; } = default!;
        public int AnimalLiveTime { get; set; }
        public int ActualLiveTime { get; set; }
        public int EatLevel { get; set; }
        public int Weight { get; set; }
    }
}
