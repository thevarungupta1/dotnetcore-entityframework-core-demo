using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace WebApplication31.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options)
        {

        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Department> Departments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Employee>()
                  .HasOne<Department>(x => x.Department)
                  .WithMany(y => y.Employees)
                  .HasForeignKey(a => a.DepartmentId);

            modelBuilder.Entity<Department>().HasData(

                new Department
                {
                    Id = 1,
                    DepName = "Admin",
                    Location = "Delhi"
                },
                new Department
                {
                    Id = 2,
                    DepName = "HR",
                    Location = "Mumbai"
                },
                new Department
                {
                    Id = 3,
                    DepName = "Sales",
                    Location = "Pune"
                }

                );
        }



    }
}
