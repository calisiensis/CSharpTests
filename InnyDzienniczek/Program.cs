using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnyDzienniczek
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary dzienniczek = new Diary();

            dzienniczek.DodajOcene(5);
            dzienniczek.DodajOcene(7.2f);
            dzienniczek.DodajOcene(4.7f);
            dzienniczek.DodajOcene(8.6f);
            dzienniczek.DodajOcene(3.1f);

            DiaryStatistics statystyki = dzienniczek.WyliczStatystyki();

            Console.WriteLine("Średnia ocena dla dzienniczka nr 1: " + statystyki.sredniaOcena);
            Console.WriteLine("Maksymalna ocena dla dzienniczka nr 1: " + statystyki.maxOcena);
            Console.WriteLine("Minimalna ocena dla dzienniczka nr 1: " + statystyki.minOcena);
            Console.WriteLine("");

            Diary dzienniczek2 = new Diary();

            dzienniczek2.DodajOcene(6.1f);
            dzienniczek2.DodajOcene(4);
            dzienniczek2.DodajOcene(6.7f);
            dzienniczek2.DodajOcene(9.5f);
            dzienniczek2.DodajOcene(0.7f);

            statystyki = dzienniczek2.WyliczStatystyki();

            Console.WriteLine("Średnia ocena dla dzienniczka nr 2: " + statystyki.sredniaOcena);
            Console.WriteLine("Maksymalna ocena dla dzienniczka nr 2: " + statystyki.maxOcena);
            Console.WriteLine("Minimalna ocena dla dzienniczka nr 2: " + statystyki.minOcena);
            Console.WriteLine("");

            //  wywołanie pól static: nazwa klasy, kropka i pole
           
            Console.WriteLine(Diary.maxOcena);
            Console.WriteLine(Diary.minOcena);
            Console.WriteLine(Diary.Licznik); // pokazuje ile mamy dzienniczków
            Console.WriteLine(dzienniczek.Licznik2); // pokazuje ile mamy instancji klasy, czyli zawsze będzie 1, bo dla każdego obiektu licznik jest zawsze inny

        }
    }
}
