using System;
using System.Collections.Generic;
using System.Text;

namespace InterfaceExercise
{
    public interface IVehicle
    {
        public int NumOfWheels { get; set; }
        public int Year { get; set; }
        public string Model { get; set; }
        public double Price { get; set; }
    }
}
