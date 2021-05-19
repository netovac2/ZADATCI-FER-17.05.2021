using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK1
{
    class Computer
    {
        public string Model { get; set; }
        public string Manufacturer { get; set; }
        public string OperatingSystem { get; set; }


        public Computer(string model, string manufacturer, string operatingSystem)
        {
            Model = model;
            Manufacturer = manufacturer;
            OperatingSystem = operatingSystem;
        }

        public override string ToString()
        {
            return "COMPUTER " + "Model: " + Model + ", " + "Manufacturer: " + Manufacturer + ", " + "Operating System: " + OperatingSystem;
        }
    }
}
