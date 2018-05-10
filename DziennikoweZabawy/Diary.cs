using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DziennikoweZabawy
{
    class Diary
    {
        public Diary()
        {
            oceny = new List<float>();
        }
        List<float> oceny; // = new List<float>(); to byśmy dali, gdyby nie konstruktor powyżej

        public void DodawanieOcen(float ocena)
        {
            oceny.Add(ocena);
        }

        public float WyliczanieSredniej()
        {
            float suma = 0, srednia = 0;

            foreach (var ocena in oceny) // zastąpiono rating zmienną ocena
            {
                suma += ocena;
            }

            srednia = suma / oceny.Count();

            return srednia;
        }

        public float PokazMaxOcene()
        {
            return oceny.Max();
        }

        public float PokazMinOcene()
        {
            return oceny.Min();
        }
    }
}
