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

        }
    }
}
