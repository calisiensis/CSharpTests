using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Konstruktory
{
    class Program
    {
        static void Main(string[] args)
        {
            Osoba osoba1 = new Osoba();
            Osoba osoba2 = new Osoba(2, "Geralt");
            Osoba osoba3 = new Osoba(3, "Letho", "z Gulety");
            Osoba osoba4 = new Osoba(4, "Triss", "Merigold", "Novigrad", 33, "Kobieta");
        }
    }
}
