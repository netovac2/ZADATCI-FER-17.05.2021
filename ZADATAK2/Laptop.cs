using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK2
{
   public class Laptop:Computer
    {
        public int BatteryCapacity { get; set; }
        public double Weight { get; set; }

        public Laptop(string model, string manufacturer, string operatingSystem, int batteryCapacity, double weight)
            : base(model, manufacturer, operatingSystem)
        {
            BatteryCapacity = batteryCapacity;
            Weight = weight;
        }

        public override string GetComputerType()
        {
            return "Laptop Computer";
        }

        public override int CalculatePortabilityScore()
        {
            int weight1 = (int)Weight;

            return weight1;
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
