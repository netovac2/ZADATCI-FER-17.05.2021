using System;

namespace ZADATAK1
{
    class Program
    {
        static void Main(string[] args)
        {
            Computer computer = new Computer("xyz", "HP", "Windows 10");
            Desktop desktop = new Desktop("zzz", "Dell", "Linux", 12);
            Laptop laptop = new Laptop("ttt", "HP", "Windows XP", 10000, 3);

            Console.WriteLine(computer.ToString());
            Console.WriteLine('\n');
            Console.WriteLine(desktop.ToString());
            Console.WriteLine('\n');
            Console.WriteLine(laptop.ToString());




        }


    }
}
