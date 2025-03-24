using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string LocationNumber { get; set; }
        public string Status { get; set; }
        public Location(int id, string locationNumber, string status)
        {
            Id = id;
            LocationNumber = locationNumber;
            Status = status;
        }
    }
}
