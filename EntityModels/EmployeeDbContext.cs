using Microsoft.EntityFrameworkCore;
using dockerproject.Models;

namespace dockerproject.EntityModels
{
    public class EmployeeDbContext : DbContext
    {
        public DbSet<Employee> Employees { get; set; }
        //temp branch
        //test merge
        public EmployeeDbContext(DbContextOptions options):base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Employee>().HasData(
                new Employee() { Id = 1, Name = "Vin", Email = "v@v.com", Address = "Hyd" },
                 new Employee() { Id = 2, Name = "Vin1", Email = "v@v1.com", Address = "Che" },
                  new Employee() { Id = 3, Name = "Vin2", Email = "v@v2.com", Address = "pdtr" }

                );
        }
    }
   
}
