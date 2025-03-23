using Microsoft.EntityFrameworkCore;
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
    }
}
