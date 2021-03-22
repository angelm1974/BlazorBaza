using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BazaBlazor.Data
{
    public class Food
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public virtual Animal Animal { get; set; }
    }
}