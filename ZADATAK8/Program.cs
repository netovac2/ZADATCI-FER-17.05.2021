using System;

namespace ZADATAK8
{
    class Program
    {
        static void Main(string[] args)
        {
            TextBook textBook = new TextBook(123, "Udžbenik", "AutorX", "Predavanja", 12, 7);
            Magazine magazine = new Magazine(333, "Mens Health", "Food", 22, 14, 5);
            EItem eItem = new EItem(444, "GitHub", "Baza za kodove", "www.github.com");
            DigitalItem digitalItem = new DigitalItem(222, "FILM", "Blue-Ray", 3, 7);
            Dictionary dictionary = new Dictionary(555, "Riječnik", "Klaić", "Hrvatski", "Engleski", 34, 6);
            Book book = new Book(444, "Enciklopedija", "AutorXX", 4, 23);


            Console.WriteLine(textBook.GetLoanPeriod());
            Console.WriteLine(magazine.GetLoanPeriod());
            Console.WriteLine(eItem.GetLoanPeriod());
            Console.WriteLine(digitalItem.GetLoanPeriod());
            Console.WriteLine(dictionary.GetLoanPeriod());
            Console.WriteLine(book.GetLoanPeriod());

            Console.WriteLine(textBook.GetLocation());
            Console.WriteLine(magazine.GetLocation());
            Console.WriteLine(digitalItem.GetLocation());
            Console.WriteLine(dictionary.GetLocation());
            Console.WriteLine(book.GetLocation());
            

            
        }
    }
}
