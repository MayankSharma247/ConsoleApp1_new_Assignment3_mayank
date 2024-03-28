using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_new_Assignment3_mayank
{
    internal class RentalAgency
    {
        private Vehicle[] fleet;
        private double totalRevenue;
        private double totalRent;

        public RentalAgency(int capacity)
        {
            fleet = new Vehicle[capacity];
        }

        public double TotalRevenue
        {
            get { return totalRevenue; }
        }

        public void AddVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < fleet.Length; i++)
            {
                if (fleet[i] == null)
                {
                    fleet[i] = vehicle;
                    Console.WriteLine($"{vehicle.Model} Added to the fleet");
                    return;
                }
            }
            Console.WriteLine("No space in Fleet");
        }

        public void RemoveVehicle(Vehicle vehicle)
        {
            for (int i = 0; i < fleet.Length; i++)
            {
                if (fleet[i] == vehicle)
                {
                    fleet[i] = null;
                    Console.WriteLine($"{vehicle.Model} Removed from the fleet");
                    return;
                }
            }
            Console.WriteLine($"{vehicle.Model} not found");
        }

        public void RentVehicle(Vehicle vehicle, int days)
        {
            if (vehicle != null)
            {
                totalRevenue = totalRevenue + (vehicle.RentalPrice * days);
                totalRent = vehicle.RentalPrice * days;
                Console.WriteLine($"{vehicle.Model} Rented for days= {days}. Total Rent: {totalRent} $");
                RemoveVehicle(vehicle);
            }
            else
            {
                Console.WriteLine("Not available for rent");
            }
        }

    }
}
