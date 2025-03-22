namespace ParkingLot.Models;

public class Customer
{
    public virtual ICollection<ParkingSession> ParkingSessions { get; set; } = new List<ParkingSession>();
    public virtual ICollection<Vehicle> Vehicles { get; set; } = new List<Vehicle>();

    public Customer(int id, string name, string email, string tel, string address, string city)
    {
        Id = id;
        Name = name;
        Email = email;
        Tel = tel;
        Address = address;
        City = city;
    }

    public int Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string Tel { get; set; }
    public string Address { get; set; }
    public string City { get; set; }

    public void AddParkingSession(ParkingSession parkingSession)
    {
        ParkingSessions.Add(parkingSession);
    }
    public void AddVehicle(Vehicle vehicle)
    {
        Vehicles.Add(vehicle);
    }

}
