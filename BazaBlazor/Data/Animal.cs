using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaBlazor.Data
{
    public class Animal
    {
        public int Id { get; set; }
        public string Species { get; set; }

        public int EmployeeId { get; set; }
        public int PavilionId { get; set; }
        public virtual Employee Employee { get; set; }
        public virtual Pavilion Pavilion { get; set; }
        public virtual List<Food> Foods { get; set; }
    }
}
