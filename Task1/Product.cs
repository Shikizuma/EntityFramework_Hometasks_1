using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntityFramework_Hometask_1
{
    public class Product
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double Cost { get; set; }
        public string? Description { get; set; }
        public int Quintity { get; set; }
     
    }
}
