using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZADATAK8
{
    class EItem:LibraryItem
    {
        public string OpisSadrzaja { get; set; }
        public string Url { get; set; }

        public EItem(int id, string name, string opisSadrzaja, string url)
            :base (id, name)
        {
            OpisSadrzaja = opisSadrzaja;
            Url = url;
        }

        public override string GetLoanPeriod()
        {
            return "Vrijeme posudbe za eSadržaj je 30 dana";
        }

        public override string GetLocation()
        {
            throw new NotImplementedException();
        }

    }
}
