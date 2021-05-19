using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK7
{
    class PassengerVan:Van
    {
        private int NoOfPassengers { get; set; }

        public PassengerVan(string registrationNo, string model, double height, int noOfPassengers)
            :base (registrationNo, model, height)
        {
            NoOfPassengers = noOfPassengers;
        }

        public override string toString()
        {
            return "PASSENGER VAN" + "Registration number: " + RegistrationNo + ", " + "Model: " + Model + ", " + "Height: " + Height + ", " + "Number of passengers: " + NoOfPassengers;
        }

        public override string getMaxPassengers()
        {
            return "This vehicle can transport next ammount of passengers" + NoOfPassengers;
        }

        public override string getMaxSpace()
        {
            return "This vehicle cannot transport cargo";
        }


    }
}
