using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _08.CarSalesman
{
    internal class Engine
    {
        public string Model { get; set; }
        public dynamic Power { get; set; }
        public dynamic Displacement { get; set; }
        public string Efficiency { get; set; }

        public Engine(string model, dynamic power, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = "n/a";
            Efficiency = efficiency;
        }

        public Engine(string model, dynamic power, dynamic displacement)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = "n/a";
        }

        public Engine(string model, dynamic power, dynamic displacement, string efficiency)
        {
            Model = model;
            Power = power;
            Displacement = displacement;
            Efficiency = efficiency;
        }
    }
}
