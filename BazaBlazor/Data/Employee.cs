using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaBlazor.Data
{
    public class Employee
    {
        public int Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public virtual List<Animal> Animals { get; set; }
    }
}
