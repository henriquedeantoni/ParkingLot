namespace ParkingLot.Models;

public class ParkingSession
{
    public int Id { get; set; }
    public decimal Interval { get; set; }
    public string StartDate { get; set; }
    public virtual Vehicle? Vehicle { get; set; }

    public ParkingSession(decimal interval, string startDate)
    {
        Interval = interval;
        StartDate = startDate;
    }

    public override string ToString()
    {
        return @$"Id: {Id}
        StartDate: {StartDate}
        Interval: {Interval}
        ";
    }
}
