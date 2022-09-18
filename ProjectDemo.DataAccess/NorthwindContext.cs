using Microsoft.EntityFrameworkCore;
using ProjectDemo.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectDemo.DataAccess
{
    public class NorthwindContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\MSSQLLocalDB;Database=Northwind;Trusted_Connection=true");
        }

        //Custom Mapping
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Fluent mapping
            //modelBuilder.HasDefaultSchema("admin");
            modelBuilder.Entity<Personel>().ToTable("Employees", "dbo");
            modelBuilder.Entity<Personel>().Property(p => p.Id).HasColumnName("EmployeeID");
            modelBuilder.Entity<Personel>().Property(p => p.SoyAd).HasColumnName("LastName");
            modelBuilder.Entity<Personel>().Property(p => p.Ad).HasColumnName("FirstName");
        }

        public DbSet<Product> Products { get; set; }
        public DbSet<Personel> Personeller { get; set; }
    }
}
