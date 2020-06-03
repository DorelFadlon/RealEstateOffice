using System;
using System.Data.Entity;

namespace RealEstateOffice.Models
{
    public class OfficeDB : DbContext
    {
        public OfficeDB()
        {

        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Broker> Brokers { get; set; }
        public DbSet<Property> Properties { get; set; }
        public DbSet<Deal> Deals { get; set; }
    }
}
