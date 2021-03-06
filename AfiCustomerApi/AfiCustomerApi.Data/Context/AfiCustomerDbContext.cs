﻿using AfiCustomerApi.Data.Models;
using Microsoft.EntityFrameworkCore;

namespace AfiCustomerApi.Data.Context
{
    public class AfiCustomerDbContext : DbContext
    {
        public AfiCustomerDbContext(DbContextOptions<AfiCustomerDbContext> options) : base(options)
        {}
        public DbSet<AfiCustomer> AfiCustomer { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
          
            modelBuilder.Entity<AfiCustomer>().HasKey(cust => cust.AfiCustomerID);
            modelBuilder.Entity<AfiCustomer>().Property(cust => cust.SurName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<AfiCustomer>().Property(cust => cust.FirstName).HasMaxLength(50).IsRequired();
            modelBuilder.Entity<AfiCustomer>().Property(cust => cust.PolicyReferenceNumber).HasMaxLength(9).IsRequired();
            
            base.OnModelCreating(modelBuilder); 
        }

    }
}
