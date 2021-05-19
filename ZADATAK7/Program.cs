using System;

namespace ZADATAK7
{
    class Program
    {
        static void Main(string[] args)
        {
            Vehicle vehicle = new Car("DA8818BB", "Renault Megane", "caravan", 4, 800);
            PassengerVan passengerVan = new PassengerVan("DA6282EA", "IMV 1688", 212, 8);
            Limo limo = new Limo("DA2238AB", "Zastava 750 LE", 320, 4, false);


        }
    }
}
