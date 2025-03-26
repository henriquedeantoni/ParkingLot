using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    public class BusinessUnit
    {
        public virtual ICollection<ParkingSpot> ParkingSpots { get; set; } = new List<ParkingSpot>(); 
        public int Id { get; set; }
        public string Name { get; set; }
        public string ContactNumber { get; set; }
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public BusinessUnit() { }
    }
}
