using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class SUV:IVehicle , ICompany
    {
        public bool RearViewCamera { get; set; }

        public int PassegerCapacity { get; set; }
        public string Slogan { get; set; }
        public string Logo { get; set; }
        public int Year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void Display()
        {
            Console.WriteLine($"{Make} {Model} {Year} Color:{Color} has a seating capacity of {PassegerCapacity} for the day to be {Slogan}!!!! ");
        }
    }
}
