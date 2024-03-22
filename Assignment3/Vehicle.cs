using System;

public class Vehicle
{
    public string Model { get; set; }
    public string Manufacturer { get; set; }
    public int Year { get; set; }
    public double RentalPrice { get; set; }

    public virtual void DisplayDetails()
    {
        Console.WriteLine($"Model: {Model}, Manufacturer: {Manufacturer}, Year: {Year}, Rental Price: {RentalPrice}");
    }
}
