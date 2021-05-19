using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK8
{
    class Book:LibraryItem, ILocation
    {
        public string Author { get; set; }

        public Book(int id, string name, string author, int red, int polica)
            :base (id, name, red, polica)
        {
            Author = author;
        }


        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za knjige je 14 dana.";
        }

        public override string GetLocation()
        {
            return $"Lokacija knjige je red broj {Red} na polici broj {Polica}";
        }


    }
}
