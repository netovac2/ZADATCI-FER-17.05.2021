using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK8
{
    class Magazine:LibraryItem, ILocation
    {
        public string ContentCategory { get; set; }
        public int Issue { get; set; }


        public Magazine(int id, string name, string contentCategory, int issue, int red, int polica)
            :base (id, name, red, polica)
        {
            ContentCategory = contentCategory;
            Issue = issue;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za časopise je 7 dana";
        }

        public override string GetLocation()
        {
            return $"Lokacija casopisa je red broj {Red} na polici broj {Polica}";
        }
    }
}
