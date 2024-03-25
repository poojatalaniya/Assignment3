using System;

public class RentalAgency
{
    private Vehicle[] Fleet { get; set; }
    public double TotalRevenue { get; private set; }

    public RentalAgency(int capacity)
    {
        Fleet = new Vehicle[capacity];
    }

    public void AddVehicle(Vehicle vehicle, int index)
    {
        Fleet[index] = vehicle;
    }

    public void RemoveVehicle(int index)
    {
        Fleet[index] = null;
    }

    public void RentVehicle(int index, int days)
    {
        if (Fleet[index] != null)
        {
            TotalRevenue += Fleet[index].RentalPrice * days;
            Console.WriteLine($"Vehicle {Fleet[index].Model} rented for {days} days. Total cost: {Fleet[index].RentalPrice * days}");
            Fleet[index] = null;
        }
        else
        {
            Console.WriteLine("Vehicle not available for rent.");
        }
    }
}
