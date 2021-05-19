using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK7
{
   class Limo:Vehicle
    {
        public double Lenght { get; set; }
        public int NoOfSeats { get; set; }
        public bool SunRoof { get; set; }

        public Limo(string registrationNo, string model, double lenght, int noOfSeats, bool sunRoof)
            :base (registrationNo, model)
        {
            Lenght = lenght;
            NoOfSeats = noOfSeats;
            SunRoof = sunRoof;
        }

        public override string toString()
        {
            return "LIMO   " + "Registration number: " + RegistrationNo + ", " + "Model: " + Model + ", " + "Lenght: " + Lenght + ", " + "Number of seats: " + NoOfSeats + ", " + "SunRoof" + SunRoof;
        }

        public override string getMaxPassengers()
        {
            return "This vehicle can transport next ammount of passenger" + NoOfSeats;
        }

        public override string getMaxSpace()
        {
            return "This vehicle cannot transport cargo";
        }
    }
}
