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
        }

        private List<float> oceny;

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
