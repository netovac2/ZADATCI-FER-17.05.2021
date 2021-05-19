using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK8
{
    class TextBook:Book, ICash, ILocation
    {
        public string Subject { get; set; }
        


        public TextBook(int id, string name, string author, string subject, int red, int polica)
            :base (id, name, author, red, polica)
        {
            Subject = subject;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za udžbenike je 120 dana";
        }

        public bool HasCashDeposit()
        {
            return true;
        }


        public double GetCashDepositAmmount()
        {
            return 20.00;
        }

        public override string GetLocation()
        {
            return $"Lokacija udžbenika je red broj {Red} na polici broj {Polica}";
        }

    }
}
