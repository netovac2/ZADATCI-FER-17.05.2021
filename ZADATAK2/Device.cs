using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK2
{
   abstract public class Device
    {
        public string Model { get; set; }

        public abstract string GetModel();

        public abstract int GetBatteryCapacity();


    }
}
