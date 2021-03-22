using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;


namespace BazaBlazor.Data

{
    public class DataAppContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite("Data Source=zoo.db");

        public DbSet<Animal> Animals { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Pavilion> Pavilions { get; set; }
        public DbSet<Food> Foods { get; set; }
    }
}