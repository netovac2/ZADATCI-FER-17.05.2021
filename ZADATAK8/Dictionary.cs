using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK8
{
    class Dictionary:Book, ILocation
    {
        public string FirstLanguage { get; set; }
        public string SecondLanguage { get; set; }
        

        public Dictionary(int id, string name, string author, string firstLanguage, string secondLanguage, int red, int polica)
            : base(id, name, author, red, polica)
        {
            FirstLanguage = firstLanguage;
            SecondLanguage = secondLanguage;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za riječnik je 14 dana";
        }

        public override string GetLocation()
        {
            return $"Lokacija časopisa je red broj {Red} na polici broj {Polica}";
        }
    }

    
    

    

}
