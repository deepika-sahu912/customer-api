using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.InMemory;
using Domain.Entities;
using Domain.Models;

namespace Persistence.Context
{
	public class CustomerContext : DbContext
	{
        
		public DbSet<CustomerDetails>? customerTables { get; set; } 

          protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
		  {
             optionsBuilder.UseInMemoryDatabase("CustomerDb");
            //optionsBuilder.UseSqlServer("Server= 192.168.1.235,1433; Initial Catalog = CustomerDatabase; User Id = SA; Password = Deerav@NL22 ; TrustServerCertificate=True") ;      
          }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CustomerDetails>(entity => entity.HasKey(p => new { p.Id }));
            modelBuilder.Entity<Customers>(entity => entity.HasKey(p => new { p.Id }));


        }
    }
}

