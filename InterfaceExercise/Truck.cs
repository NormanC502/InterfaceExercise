using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Truck:IVehicle , ICompany
    {
        public bool ExtendedCabin{ get; set;}

        public string BedSize { get; set; }
        public string Slogan { get; set; }
        public string Logo { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Make} {Model} {Year} Color:{Color} has a {BedSize} of strech-out and sleep space, where you wake up and scream {Slogan}!!!!\n ");
        }
    }
}
