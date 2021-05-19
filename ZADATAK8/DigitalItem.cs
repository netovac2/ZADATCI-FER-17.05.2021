using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK8
{
    class DigitalItem:LibraryItem, ICash, ILocation
    {
        public string Type { get; set; }
       



        public DigitalItem(int id, string name, string type, int red, int polica)
            :base (id, name, red, polica)
        {
            Type = type;
        }


        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbne za digitalni sadržaj je 30 dana";
        }

        public bool HasCashDeposit()
        {
            return true;
        }

        public double GetCashDepositAmmount()
        {
            return 35.00;
        }

        public override string GetLocation()
        {
            return $"Lokacija je red broj {Red} na polici broj {Polica}";
        }

    }
}
