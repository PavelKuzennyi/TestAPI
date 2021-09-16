using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using TestAPI.Models;

namespace TestAPI.Data
{
    public sealed class TestApiContext : DbContext
    {
        public DbSet<ConcurrentLogin> ConcurrentLogins { get; set; }
        public DbSet<DeviceRegistration> DeviceRegistrations { get; set; }
        public DbSet<SessionDuration> SessionDuration { get; set; }
        public DbSet<UserCountryLog> UserCountryLogs { get; set; }
        public DbSet<UserDevice> UserDevices { get; set; }
        public DbSet<UserRegistration> UserRegistrations { get; set; }
        public TestApiContext()
        {
            Database.EnsureCreated();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=helloappdb;Trusted_Connection=True;");
        }
        
 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // использование Fluent API
            base.OnModelCreating(modelBuilder);
        }
    }
}