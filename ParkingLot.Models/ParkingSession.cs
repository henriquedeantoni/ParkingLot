namespace ParkingLot.Models;

public class ParkingSession
{
    public int Id { get; set; }
    public decimal Interval { get; set; }
    public string StartDate { get; set; }
    public string Status { get; set; }
    public string Location { get; set; }
    public virtual Vehicle? Vehicle { get; set; }
    public virtual Customer? Customer { get; set; }

    public ParkingSession(decimal interval, string startDate, string status)
    {
        Interval = interval;
        StartDate = startDate;
        Status = status;
    }

    public override string ToString()
    {
        return @$"Id: {Id}
        StartDate: {StartDate}
        Interval: {Interval}
        Status: {Status}
        ";
    }
}
