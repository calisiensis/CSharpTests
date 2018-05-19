using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InnyDzienniczek
{
    class Diary
    {
        public Diary()
        {
            oceny = new List<float>();
            Licznik++;
            Licznik2++;
        }

        private List<float> oceny;

        // Static - daje dostęp do pól i metod bez tworzenia instancji klasy
        public static float minOcena = 0;
        public static float maxOcena = 10;
        public static long Licznik = 0; // liczy liczbę słowników
        public long Licznik2 = 0; // gdyby Licznik nie był static

        public void DodajOcene(float ocena)
        {
            if (ocena >= 0 && ocena <= 10)
            {
                oceny.Add(ocena);
            }
        }

        public DiaryStatistics WyliczStatystyki()
        {
            DiaryStatistics statystyki = new DiaryStatistics();

            float suma = 0f;

            foreach (var ocena in oceny)
            {
                suma += ocena;
            }

            statystyki.sredniaOcena = suma / oceny.Count();
            statystyki.maxOcena = oceny.Max();
            statystyki.minOcena = oceny.Min();

            return statystyki;
        }
    }
}
