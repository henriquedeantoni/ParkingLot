namespace ParkingLot.Models;

public class Vehicle
{
    public Vehicle(int id, string vehicleModel, string brand, string licensePlate) 
    {
        Id = id;
        VehicleModel = vehicleModel;
        Brand = brand;
        LicensePlate = licensePlate;
    }
    public int Id { get; set; }
    public string VehicleModel { get; set; }
    public string Brand { get; set; }
    public string LicensePlate { get; set; }
    public virtual Customer? Customer { get; set; }

    public void ShowVehicleInformation()
    {
        Console.WriteLine($"LicensePlate: {LicensePlate}");
    }

    public override string ToString()
    {
        return $@"Id: {Id}
        Vehicle Model: {VehicleModel}
        Brand: {Brand}
        License Plate: {LicensePlate}
        ";
    }

}
