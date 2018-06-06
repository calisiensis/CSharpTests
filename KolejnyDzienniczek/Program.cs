using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace KolejnyDzienniczek
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

            WypiszRezultat("Średnia ocena", statystyki.sredniaOcena); // zawsze będzie ta metoda wywoływać pierwszą metodą, gdyż przekazujemy do niej stringa i floata
            WypiszRezultat("Maksymalna ocena", (int)statystyki.maxOcena); // jak chcemy inne, to trzeba rzutować
            WypiszRezultat("Minimalna ocena", (long)statystyki.minOcena); // jak wyżej
            WypiszRezultat("Minimalna ocena", (long)statystyki.minOcena, 1); // uruchomienie szóstej metody (wcześniej czwartej)
            WypiszRezultat("Średnia ocena", statystyki.sredniaOcena, 3, 5, 7, 8, 9); // uruchomienie metody z "params"
            Console.WriteLine("");

            dzienniczek.Name = "Dzienniczek Imleritha";
            Console.WriteLine(dzienniczek.Name);
        }
        static void WypiszRezultat(string opis, float ocena)
        {
            Console.WriteLine(opis + ": " + ocena);
        }

        static void WypiszRezultat(string opis, int ocena) // przeciążamy metodę
        {
            Console.WriteLine(opis + ": " + ocena);
        }
        static void WypiszRezultat(string opis, long ocena) // przeciążamy metodę
        {
            Console.WriteLine(opis + ": " + ocena);
        }
        static void WypiszRezultat(string opis, long ocena, long test) // przeciążamy metodę
        {
            Console.WriteLine(opis + ": " + ocena);
        }
        static void WypiszRezultat(string opis, params float[] ocena) // params - kluczowe słowo dodawane do ostatniego parametru metody
        {
            Console.WriteLine(opis + ": " + ocena[0] + " " + ocena[4]);
        }
        static void WypiszRezultat(string opis, long ocena, int test) // używanie placeholderów
        {
            Console.WriteLine("{0}: {1:F2}: {2:C}: {3}: {4}: {5} ", opis, ocena, 2, 3, 4, 5); // konwertowanie na floata z 2 miejscami po przecinku w drugim elemencie, w trzecim - konwersja do waluty
            Console.WriteLine($"{opis}: {ocena:F2}: {2:C}: {3}: {4}: {5} ", 2, 3, 4, 5); // dając znaczek dolara, od razu w placeholderach możemy dać opis i ocenę
        }
    }
}
