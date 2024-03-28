using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1_new_Assignment3_mayank
{
    internal class Car: Vehicle

    {
        private int seats { get; set; }
        private string engineType { get; set; }
        private string transmission { get; set; }
        private bool convertible { get; set; }


        public Car(string Model, string Manufacturer, int Year, double RentalPrice, int Seats, string EngineType, string Transmission, bool Convertible) : base(Model, Manufacturer, Year, RentalPrice)
        {
            seats = Seats;
            engineType = EngineType;
            transmission = Transmission;
            convertible = Convertible;
        }



        public override void DisplayDetails()
        {
            base.DisplayDetails();
            Console.WriteLine($"Seats- {seats}");
            Console.WriteLine($"Engine Type- {engineType}");
            Console.WriteLine($"Transmission- {transmission}");

            if (convertible == true)
            {
                Console.WriteLine("Convertible- Yes");
            }
            else
            {
                Console.WriteLine("Convertible- No");
            }

        }
    }
}
