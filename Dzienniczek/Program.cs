using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dzienniczek
{
    class Program
    {
        static void Main(string[] args)
        {
            ElektroDziennik elektrodziennik = new ElektroDziennik();

            for (; ; )
            {
                Console.Write("Podaj ocenę z zakresu 0.1 - 10 (liczba 69 powoduje wyjście z pętli): ");

                float ocena;

                bool result = float.TryParse(Console.ReadLine(), out ocena);

                if(ocena == 69)
                {
                    break;
                }
                else if (ocena == 0)
                {
                    Console.WriteLine("Niepoprawna ocena, podaj liczbę z zakresu 0.1 - 10");
                    continue;
                }

                if (result == true) // może być samo result
                {
                    if (ocena > 0 && ocena <= 10)
                    {
                        elektrodziennik.DodawanieOcen(ocena);
                        continue;
                    }

                    else
                    {
                        Console.WriteLine("Niepoprawna ocena, podaj liczbę z zakresu 0.1 - 10");
                        continue;
                    }

                }


                elektrodziennik.DodawanieOcen(ocena);
            }

            Console.WriteLine("Średnia Twoich ocen to: " + elektrodziennik.WyliczanieSredniej());
            Console.WriteLine("Najwyższa ocena to: " + elektrodziennik.PokazMaxOcene());
            Console.WriteLine("Najniższa ocena to: " + elektrodziennik.PokazMinOcene());
            Console.ReadKey();
        }
    }
}
