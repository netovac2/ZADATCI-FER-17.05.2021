using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK7
{
   abstract public class Vehicle
    {
        public string RegistrationNo { get; private set; }
        public string Model { get; private  set; }

        public Vehicle(string registrationNo, string model)
        {
            RegistrationNo = registrationNo;
            Model = model;
        }

        public abstract string toString();


        public abstract string getMaxSpace();


        public abstract string getMaxPassengers();
       

    }
}
