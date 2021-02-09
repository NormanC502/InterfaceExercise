using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    class Car:IVehicle , ICompany
    {
       public string HorsePower { get; set; } 
       public bool CruiseControl { get; set; }
       public string Logo { get; set; }
       public int Year { get; set; }
       public string Make { get; set; }
       public string Model { get; set; }
       public string Color { get; set; }
       public string Slogan { get; set; }

        public void Display() 
        {
            Console.WriteLine($"{Make} {Model} {Year} Color:{Color} is breath taking awesomeness with {HorsePower} screaming {Slogan}!!!!\n");
        }
    }
}
