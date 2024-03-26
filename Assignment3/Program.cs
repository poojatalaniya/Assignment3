//Assignment3
//By Pooja Talaniya, Student ID-8904569, E-mail-Ptalaniya4569@conestogac.on.ca
//Beginning of the code
using System;

class Program
{
    static void Main(string[] args)
    {
        // Creating instances of vehicles
        Car car = new Car
        {
            Model = "Civic",
            Manufacturer = "Honda",
            Year = 2022,
            RentalPrice = 50,
            Seats = 5,
            EngineType = "Petrol",
            Transmission = "Automatic",
            Convertible = false
        };

        Truck truck = new Truck
        {
            Model = "F-150",
            Manufacturer = "Ford",
            Year = 2020,
            RentalPrice = 100,
            Capacity = 1000,
            TruckType = "Pickup",
            FourWheelDrive = true
        };

        Motorcycle motorcycle = new Motorcycle
        {
            Model = "Ninja",
            Manufacturer = "Kawasaki",
            Year = 2021,
            RentalPrice = 30,
            EngineCapacity = 600,
            FuelType = "Petrol",
            HasFairing = true
        };

        // Creating rental agency
        RentalAgency agency = new RentalAgency(10);

        // Adding vehicles to the agency's fleet
        agency.AddVehicle(car, 0);
        agency.AddVehicle(truck, 1);
        agency.AddVehicle(motorcycle, 2);

        // Renting a vehicle
        agency.RentVehicle(1, 5);          // Renting the truck for 5 days


        // Displaying remaining fleet and total revenue
        Console.WriteLine("\nRemaining Fleet:");
        for (int i = 0; i < 3; i++)
        {
            if (agency.Fleet[i] != null)
            {
                Console.Write($"{i + 1}. ");
                agency.Fleet[i].DisplayDetails();
            }
        }

        Console.WriteLine($"\nTotal Revenue: {agency.TotalRevenue}");
    }
}
