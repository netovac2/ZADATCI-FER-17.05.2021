using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK7
{
   class Car:Vehicle
    {
        public string CarType { get; set; }
        public int NoOfSeats { get; set; }
        public double CargoSpace { get; set; }

        public Car(string registrationNo, string model, string carType, int noOfSeats, double cargoSpace)
            :base (registrationNo, model)
        {
            CarType = carType;
            NoOfSeats = noOfSeats;
            CargoSpace = cargoSpace;
        }

        public override string toString()
        {
            return "CAR   " + "Registration number: " + RegistrationNo + ", " + "Model: " + Model + "Car Type: " + CarType + ", " + "Number of seats: " + NoOfSeats + ", " + "Cargo Space" + CargoSpace + "l";
        }

        public override string getMaxSpace()
        {
            return "This passenger vehicle can also transport cargo. " + "Maximum cargo space is: " + CargoSpace + "l";
        }

        public override string getMaxPassengers()
        {
            return "This vehicle can transport next ammount of passengers" + NoOfSeats;
        }
    }
}
