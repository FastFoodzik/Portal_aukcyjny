using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;

namespace Portal_aukcyjny
{
    internal class Message
    {
        public void DisplayWelcomeScreen()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            Console.WriteLine("WYBIERZ OPCJĘ:");
            Console.WriteLine();
            Console.WriteLine("1 => ZAKUP");
            Console.WriteLine();
            Console.WriteLine("2 => SPRZEDAŻ");
            Console.WriteLine();
            Console.WriteLine("3 => ZAKOŃCZ");
            Console.WriteLine();
            Console.WriteLine("WYBIERZ 1,2 LUB 3");
            Console.WriteLine();
        }

        public void DisplayItems()
        {
            Console.Clear();
            Console.WriteLine();
            Console.WriteLine("LISTA PRZEDMIOTÓW NA AUKCJI");
            Console.WriteLine();
            Console.WriteLine("----------------------------");
            Console.WriteLine();
        }

        public int ItemNumber() 
        {
            int identyfikator;
            Console.WriteLine();
            Console.WriteLine("PODAJ NUMER PRODUKTU KTÓRY CHCESZ ZAKUPIĆ: ");
            Console.WriteLine();
            identyfikator = int.Parse(Console.ReadLine());

            return identyfikator;
                
          


           
        }

        public int CardNumber()
        {
            Console.Clear();
            int numer_karty;
            Console.WriteLine();
            Console.WriteLine("PODAJ NUMER KARTY KREDYTOWEJ (1, 2, 3 LUB 4): ");
            Console.WriteLine();
            
            numer_karty = int.Parse(Console.ReadLine());
            

            return numer_karty;
        }

        public string AddName()
        {
            Console.Clear();
            string nazwa_produktu;
            Console.WriteLine();
            Console.WriteLine("PODAJ NAZWĘ PRZEDMIOTU, KTÓRY CHCESZ SPRZEDAĆ ");
            Console.WriteLine();

            nazwa_produktu = Console.ReadLine();


            return nazwa_produktu;
        }

        public string AddCategory()
        {
            Console.Clear();
            string kategoria_produktu;
            Console.WriteLine();
            Console.WriteLine("PODAJ KATEGORIĘ PRZEDMIOTU, DO KTÓREJ NALEŻY PRODUKT: ");
            Console.WriteLine();

            kategoria_produktu = Console.ReadLine();


            return kategoria_produktu;
        }

        public decimal AddPrice()
        {
            Console.Clear();
            decimal cena_produktu;
            Console.WriteLine();
            Console.WriteLine("PODAJ CENĘ PRZEDMIOTU, KTÓRĄ CHCESZ OTRZYMAĆ: ");
            Console.WriteLine();

            cena_produktu = decimal.Parse(Console.ReadLine());


            return cena_produktu;
        }

        public string PrimeOrNot()
        {
            Console.Clear();
            string czy_wyrozniony;
            Console.WriteLine();
            Console.WriteLine("Napisz 'tak' JEŻELI PRZEDMIOT MA BYĆ PROMOWANY: ");
            Console.WriteLine();

            czy_wyrozniony = Console.ReadLine();


            return czy_wyrozniony;
        }

        public void Bought(string nazwa, decimal cena, string nazwa_karty, int numer_karty)
        {
            
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine("Kupiłeś przedmiot: " + nazwa);
            Console.WriteLine();
            Console.WriteLine("Cena: " + cena);
            Console.WriteLine();
            Console.WriteLine("Płatność kartą: " + nazwa_karty + " (nr karty " + numer_karty + ")");
            Console.WriteLine();
            Console.WriteLine("Zakup opłacony.");
            Console.ForegroundColor = ConsoleColor.White;
        }

        public void Failure()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("NIEWYSTARCZAJĄCY LIMIT NA RACHUNKU KARTY");
            Console.WriteLine();
        }

        public void EndOfProgramBeforeEvenStart()
        {
            Console.WriteLine();
            Console.WriteLine("SZKODA, ŻE NAS OPUSZCZASZ :(");
        }
    }
}



