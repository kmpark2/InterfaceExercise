using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {
        public int NumOfWheels { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
        public string Make { get; set; }
        public string Logo { get; set; }
        public double CargoHoldSize { get; set; }
        public bool IsSUV { get; set; }
    }
}
