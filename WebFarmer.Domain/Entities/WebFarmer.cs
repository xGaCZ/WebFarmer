using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebFarmer.Domain.Entities
{
    public class WebFarmer
    {
        public  int Id { get; set; }
        public string Name { get; set; } = default!;
        public int Cash { get; set; }

    }
}
