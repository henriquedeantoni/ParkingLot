﻿using Microsoft.EntityFrameworkCore;
using ParkingLot.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Data.Data
{
    public class ParkingLotContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
        public DbSet<ParkingSession> ParkingSessions { get; set; }
        public DbSet<Vehicle> Vehicles { get; set; }
        public DbSet<ParkingSpot> ParkingSpots { get; set; }
        public DbSet<BusinessUnit> BusinessUnits { get; set; }

        private string connection = EnvConfig.GetEnvVariable("STRING_CONNECTION");

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(connection);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Customer>()
                        .HasMany(c => c.Vehicles)
                        .WithOne(c => c.Customer);

            modelBuilder.Entity<Customer>()
                        .HasMany(c => c.ParkingSessions)
                        .WithOne(c => c.Customer);

            modelBuilder.Entity<BusinessUnit>()
                        .HasMany(c => c.ParkingSpots)
                        .WithOne(c => c.BusinessUnit);

        }

    }
}
