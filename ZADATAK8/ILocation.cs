using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK8
{
    interface ILocation
    {
        public int Red { get; set; }
        public int Polica { get; set; }



        public string GetLocation();
    }
}
