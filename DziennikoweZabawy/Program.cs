using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziennikoweZabawy
{
    class Program
    {
        static void Main(string[] args)
        {
            Diary dzienniczek = new Diary(); // dzienniczek to zmienna referencyjna, bo przechowuje wskaźniki do obiektów
            dzienniczek.DodawanieOcen(3);
            dzienniczek.DodawanieOcen(5);
            
            Diary dzienniczek2 = dzienniczek; // wskazywanie na obiekt - będą przechowywać po 3 oceny
            dzienniczek2.DodawanieOcen(8);

            Diary dzienniczek3 = dzienniczek2; // combo wskaźnikowe
            dzienniczek3.DodawanieOcen(1);
        }
    }
}
