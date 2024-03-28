using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_new_Assignment3_mayank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Vehicle vehicle = new Vehicle();
            // Creation of vehicles
            Car car = new Car("Elantra", "Hyundai", 2023, 70.00, 5, "Petrol", "Manual", false);
            Truck truck = new Truck("Gwagon", "Mercedes", 2024, 500.00, 2.5, "Pickup", true);
            Motorcycle motorcycle = new Motorcycle("S1000RR", "BMW", 2023, 50.00, 800, "Petrol", true);

            // Display details
            Console.WriteLine("Car Details:");
            car.DisplayDetails();

            Console.WriteLine("\nTruck Details:");
            truck.DisplayDetails();

            Console.WriteLine("\nMotorcycle Details:");
            motorcycle.DisplayDetails();

            //// Creation  of rentalagency
            RentalAgency rentalAgency = new RentalAgency(10);

            // Add vehicles in fleet
            rentalAgency.AddVehicle(car);
            rentalAgency.AddVehicle(truck);
            rentalAgency.AddVehicle(motorcycle);

            // Rental
            rentalAgency.RentVehicle(car, 10);
            rentalAgency.RentVehicle(truck, 15);

            //display Revenue
            Console.WriteLine($"\nTotal Revenue: {rentalAgency.TotalRevenue} $");
            Console.ReadLine();
        }
    }
}
