using System;
using System.Collections.Generic;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            //Creatively display and organize their values
            var lexus = new Car() { NumOfWheels = 4, Year = 2015, Model = "CT200H", Price = 32200, Make = "Lexus", Logo = "L in a circle", HasTrunk = true, IsCar = true };
            var chevy = new Truck() { NumOfWheels = 4, Year = 2022, Model = "Silverado 2500", Price = 63480, Make = "Chevrolet", Logo = "yellow bowtie", BedSize = 71.70, IsTruck = true };
            var ford = new SUV() { NumOfWheels = 4, Year = 2022, Model = "XC90", Price = 71900, Make = "Ford", Logo = "'Ford' in white lettering inside a blue ellipse", CargoHoldSize = 85.7, IsSUV = true };

            Console.WriteLine($"{lexus.Year} {lexus.Make} {lexus.Model} is priced at ${lexus.Price}. The vehicle looks fantastic with its logo '{lexus.Logo}' prominent in the front.");
            if (lexus.HasTrunk && lexus.IsCar)
            {
                Console.WriteLine("This car has a nice trunk as well.");
            }
            Console.WriteLine($"{chevy.Year} {chevy.Make} {chevy.Model} is priced at ${chevy.Price}. The vehicle looks fantastic with its logo '{chevy.Logo}' prominent in the front.");
            if (chevy.IsTruck)
            {
                Console.WriteLine($"This truck has the cargo volume of {chevy.BedSize} cubic feet as well.");
            }
            Console.WriteLine($"{ford.Year} {ford.Make} {ford.Model} is priced at ${ford.Price}. The vehicle looks fantastic with its logo '{ford.Logo}' prominent in the front.");
            if (ford.IsSUV)
            {
                Console.WriteLine($"This SUV has the cargo volume of {ford.CargoHoldSize} cubic feet as well.");
            }
        }
    }
}
