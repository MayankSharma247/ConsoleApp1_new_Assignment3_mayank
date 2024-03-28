using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_new_Assignment3_mayank
{
    internal class Truck: Vehicle
    {
        private double capacity;
        private string truckType;
        private bool fourWheelDrive;


        public Truck(string model, string manufacturer, int year, double rentalPrice, double Capacity, string TruckType, bool FourWheelDrive) : base(model, manufacturer, year, rentalPrice)
        {

            capacity = Capacity;
            truckType = TruckType;
            fourWheelDrive = FourWheelDrive;

        }


        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Capacity- {capacity} tons");
            Console.WriteLine($"Truck Type- {truckType}");

            if (fourWheelDrive == true)
            {
                Console.WriteLine("Four Wheel Drive- Yes");
            }
            else
            {
                Console.WriteLine("Four Wheel Drive- No");
            }

        }


    }
}
