using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK7
{
    abstract class Van:Vehicle
    {
        public double Height { get; set; }

        public Van(string registrationNo, string model, double height)
            :base (registrationNo, model)
        {
            Height = height;
        }

        public override string toString()
        {
            return "VAN   " + "Registration number: " + RegistrationNo + ", " + "Model: " + Model + ", " + "Height: " + Height;
        }
    }
}
