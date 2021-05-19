using System;

namespace ZADATAK2
{
    class Program
    {
        static void Main(string[] args)
        {
            Netbook computer = new Netbook("IdeaPad S12", "Lenovo", "Windows", 50, 1.55);

            Console.WriteLine(computer.toString());
            Console.WriteLine(computer.CalculatePortabilityScore());
            Console.WriteLine(computer.GetComputerType());
            Console.WriteLine(computer.GetBatteryCapacity());
            

        }
    }
}
