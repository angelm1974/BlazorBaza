using System;
using System.Linq;
using System.Threading.Tasks;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace BazaBlazor.Data
{
    public class ZooService
    {
        DataAppContext db = new DataAppContext();

        public ZooService()
        {

        }

        public Task<List<Employee>> GetEmploys()
        {
            return Task.FromResult(db.Employees.ToList());
        }

        public void Dodaj()
        {
                Console.WriteLine("Inserting a new Employee");
                db.Add(new Employee{Firstname="Adam",Lastname="Owoc" });
                db.SaveChanges();     
        }

    }
}