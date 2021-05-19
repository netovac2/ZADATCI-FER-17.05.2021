using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK2
{

    public sealed class Netbook : Laptop
        {
            public Netbook(string model, string manufacturer, string operatingSystem, int batteryCapacity, double weight)
                : base(model, manufacturer, operatingSystem, batteryCapacity, weight)
            {

            }

            public int CalculatePortabilityScore()
            {
                return 1;
            }

            public string GetComputerType()
            {
                return "Netbook";
            }

            public string toString()
            {
                return Model + " " + "Manufacturer: " + Manufacturer + ", " + "Operating System: " + OperatingSystem + ", " + "Battery Capacity: " + BatteryCapacity + ", " + "Weight: " + Weight;
            }

        public override int GetBatteryCapacity()
        {
            return BatteryCapacity;
        }

        public override string GetModel()
        {
            return Model;
        }


    }
}
