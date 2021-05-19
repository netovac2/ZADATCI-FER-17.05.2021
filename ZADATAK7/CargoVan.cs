using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK7
{
    class CargoVan:Van
    {
        private double MaxSpace { get; set; }

        public CargoVan(string registrationNo, string model, double height, double maxSpace)
            :base (registrationNo, model, height)
        {
            MaxSpace = maxSpace;
        }

        public override string toString()
        {
            return "CARGO VAN" + "Registration number: " + RegistrationNo + ", " + "Model: " + Model + ", " + "Height: " + Height + ", " + "Maximum space" + MaxSpace + "l";
        }

        public override string getMaxPassengers()
        {
            return "This vehicle cannot transport passengers"; 
        }

        public override string getMaxSpace()
        {
            return "Maximum cargo space is: " + MaxSpace + "l";
        }
    }
}
