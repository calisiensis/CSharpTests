using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Powitanie
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Out.WriteLine("Pierwsze kroki w GitHubie!"); // zostało mi z Javy. Ten Out po Console nie jest potrzebny
            Console.WriteLine("C# to nie Java, tu OUT nie jest potrzebny :)");
            Console.WriteLine("");

            foreach (var item in args) //Debugowanie -> właściwości -> elementy w tablicy imion
            {
                Console.WriteLine("Witaj, " + item);
            }
            for (; ; ) // pętla na nieskończone wykonywanie się programu
            { 
            Console.Write("\nWpisz swoje imię: "); //używamy \n zamiast kolejnej linijki kodu z Console.WriteLine();
            string name = Console.ReadLine();
            Console.WriteLine("Witaj, " + name);
            Console.Write("Wpisz ile masz lat: ");
            int wiek;
            bool result = int.TryParse(Console.ReadLine(), out wiek); //nie da się wpisać tu inta bezpośrednio, trzeba sparsować do inta - int.Parse, ale żeby zabezpieczyć się przed wpisaniem litery zamiast liczby, dajemy TryParse

            if (wiek >= 18)
            {
                Console.ForegroundColor = ConsoleColor.Green; // ustawianie kolorowych wydruków
                Console.WriteLine("\nMożesz napić się temerskiej żytniej, takiej chłodnej, prosto z piwniczki :)");
            }
            else if (result == false) // sprawdzamy parsowanie literek do wieku, który parsowany jest do zera
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Nie ma takie wprowadzania wieku, znikaj stąd!");
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Pij mleko albo wodę z kałuży!");
            }
                Console.ReadKey(); // program nie zakończy się bez naciśnięcia jakiegoś klawisza
                Console.Clear(); // czyszczenie ekranu
                Console.ResetColor(); // przywraca pierwotne ustawienia koloru

        }
        }
    }
}
