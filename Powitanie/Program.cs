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
            Console.Write("\nWpisz swoje imię: "); //używamy \n zamiast kolejnej linijki kodu z Console.WriteLine();
            string name = Console.ReadLine();
            Console.Write("Wpisz ile masz lat: ");
            int wiek = int.Parse(Console.ReadLine()); //nie da się wpisać tu inta bezpośrednio, trzeba sparsować do inta - int.Parse

            if (wiek >= 18)
            {
                Console.WriteLine("\nMożesz napić się temerskiej żytniej :)"); 
            }
            else Console.WriteLine("Pij mleko albo wodę z kałuży!");

            Console.ReadKey(); //program nie zakończy się bez naciśnięcia jakiegoś klawisza
        }
    }
}
