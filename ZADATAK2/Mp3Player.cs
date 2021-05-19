using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK2
{
    class Mp3Player:Device
    {
        public int BatteryCapacity { get; set; }
        public int MemorySize { get; set; }

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
