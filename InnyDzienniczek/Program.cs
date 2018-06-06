using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Speech.Synthesis;


namespace InnyDzienniczek
{
    class Program
    {
        // przekazywanie parametrów do metody

        static void nazwijDzienniczek(ref Diary dzienniczek) // tworzymy referencje - parametr bedzie przekazywany przez wskaźnik, nie przez wartość
        {
            dzienniczek = new Diary();
            dzienniczek.Name = "Nowy Dzienniczek Geralta";
        }

        static void inkrementacja(ref int numer)
        {
            numer += 1;
        }

        static void inkrementacja2(ref int number)
        {
            number = 42;
        }

        static void inkrementacja3(out int numerek) // out - oznacza zmienną, która gdzieś już została zainicjowana
        {
            numerek = 66;
        }
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

            // Testowanie typów referencyjnych i wartościowych 

            Diary dzienniczek3 = new Diary();
            Diary dzienniczek4 = dzienniczek3;

            nazwijDzienniczek(ref dzienniczek3);
             
            //dzienniczek3 = new Diary();

            // już się tak nie będzie nazywał jak poniżej, metoda nazwijDzienniczek nadpisała w obiekcie jego nazwę (zmienna dzienniczek jako parametr w metodzie wskazuje na ten sam obiekt)
            //dzienniczek3.Name = "Dzienniczek Zoltana";
            Console.WriteLine(dzienniczek3.Name);

            int x1 = 4;
            int x2 = x1; // x2 staje się niezależną zmienną
            x1 = 100; // dlatego x2 dalej będzie wynosiła 4, bo została skopiowana  
            Console.WriteLine(x2);
            Console.WriteLine();

            // wywolanie metody inkrementacja

            int cyfra = 4;
            inkrementacja(ref cyfra);
            Console.WriteLine(cyfra); // wyjdzie 4, bo to tylko wypisuje oryginalną zmienną cyfra, która się nie zmienia, a metoda działa na kopii, ale jak sie doda "ref", to już wyjdzie  5

            int cyfra2 = 5;
            inkrementacja2(ref cyfra2);
            Console.WriteLine(cyfra2); // wyjdzie 42

            int cyfra3; // nie trzeba inicjalizować, bo z metody inkrementacja3 wyjdzie 66
            inkrementacja3(out cyfra3);
            Console.WriteLine(cyfra3);

            // porównywanie zmiennych

            string name1 = "Eredin";
            string name2 = "eredin";

            bool areEqual = name1.Equals(name2, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(areEqual);

            // przycinanie stringów z białych znaków

            string name3 = "  Jaskier  ";
            name3 = name3.Trim();
            Console.WriteLine(name3);

            // zabawy z datami

            DateTime date = DateTime.Now;
            Console.WriteLine(date);

            DateTime date2 = new DateTime(2018, 06, 01);
            date2 = date2.AddHours(48);
            Console.WriteLine(date2);


            SpeechSynthesizer synt = new SpeechSynthesizer();
            synt.Speak("Jestem gadającym komputerem!");
            Console.ReadKey();
              


        }
    }
}
