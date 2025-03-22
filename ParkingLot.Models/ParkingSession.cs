namespace ParkingLot.Models;

public class ParkingSession
{

    public decimal Interval { get; set; }
    public string StartDate { get; set; }

    public ParkingSession(decimal interval, string startDate)
    {
        Interval = interval;
        StartDate = startDate;
    }
}
