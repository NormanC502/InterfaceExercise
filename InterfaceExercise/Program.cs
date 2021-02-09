using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //Complete  TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Complete  Create 2 Interfaces called IVehicle & ICompany

            //Complete  Create 3 classes called Car , Truck , & SUV

            //Complete  In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //Complete  In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //Complete  In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values

            var vehicles = new List<IVehicle>();

            Car ride = new Car {Make = "Chevy", Model = "Corvette", Year = 2021,  HorsePower = "490 HP", CruiseControl = true, Slogan = "Find New Roads", Color = "Blue", Logo = "Bowtie" };

            Truck hauler = new Truck { Make = "Ford", Model = "Raptor", Year = 2021, BedSize = "66 inches", ExtendedCabin = true, Slogan = "Built Ford Tough", Color = "Red", Logo = "Ford name circled in Blue and white" };

            SUV hybrid = new SUV { Make = "Honda", Model = "CRV EXL", Year = 2021, PassegerCapacity = 5, RearViewCamera = true, Slogan = "The Power of Dreams", Color = "Black", Logo ="Capital H in a distinctive design Design" };

            vehicles.Add(ride);
            vehicles.Add(hauler);
            vehicles.Add(hybrid);

            ride.Display();
            hauler.Display();
            hybrid.Display();
        }
    }
}
