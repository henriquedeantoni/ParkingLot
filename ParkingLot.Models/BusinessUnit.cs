using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParkingLot.Models
{
    internal class BusinessUnit
    {
        public virtual ICollection<Location> Locations { get; set; } = new List<Location>(); 
        public string StreetAddress { get; set; }
        public string City { get; set; }
        public BusinessUnit() { }
    }
}
