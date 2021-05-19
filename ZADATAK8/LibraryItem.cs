using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK8
{
    abstract public class LibraryItem: ILocation
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int Red { get; set; }
        public int Polica { get; set; }


        public LibraryItem(int id, string name, int red, int polica)
        {
            Red = red;
            Polica = polica;
            Id = id;
            Name = name;
        }

        protected LibraryItem(int id, string name)
        {
            Id = id;
            Name = name;
        }

        abstract public string GetLoanPeriod();

        abstract public string GetLocation();
        
            
        
    }
}
