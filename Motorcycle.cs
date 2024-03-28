using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_new_Assignment3_mayank
{
    internal class Motorcycle: Vehicle

    {
        private double engineCapacity;
        private string fuelType;
        private bool hasFairing;


        public Motorcycle(string model, string manufacturer, int year, double rentalPrice, double EngineCapacity, string FuelType, bool HasFairing) : base(model, manufacturer, year, rentalPrice)
        {

            engineCapacity = EngineCapacity;
            fuelType = FuelType;
            hasFairing = HasFairing;
        }


        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Engine Capacity- {engineCapacity} cc");
            Console.WriteLine($"Fuel Type- {fuelType}");
            if (hasFairing == true)
            {
                Console.WriteLine("Has Fairing- Yes");
            }
            else
            {
                Console.WriteLine("Has Fairing- No");
            }

        }
    }
}
