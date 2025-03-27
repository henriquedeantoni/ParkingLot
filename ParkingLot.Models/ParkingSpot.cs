namespace ParkingLot.Models;
public class ParkingSpot
{
    public int Id { get; set; }
    public string LocationNumber { get; set; }
    public string Status { get; set; }

    public virtual BusinessUnit BusinessUnit {get; set;}
    public ParkingSpot(int id, string locationNumber, string status)
    {
        Id = id;
        LocationNumber = locationNumber;
        Status = status;
    }
}
