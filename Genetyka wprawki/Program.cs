using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genetyka_wprawki
{
    class Program        
    {
        static void Main(string[] args)
        {
            Populacja test = new Populacja();
            Console.WriteLine(" 1 pokolenie");
            test.wypisz();
            test.selekcja();
            Console.WriteLine("Selekcja");
            test.wypisz();
            test.reproduce();
            Console.WriteLine(" 2 pokolenie");
            test.wypisz();

            test.selekcja();
            Console.WriteLine("Selekcja");
            test.wypisz();
            test.reproduce();
            Console.WriteLine(" 3 pokolenie");
            test.wypisz();

            test.selekcja();
            Console.WriteLine("Selekcja");
            test.wypisz();
            test.reproduce();
            Console.WriteLine(" 4 pokolenie");
            test.wypisz();

            test.selekcja();
            Console.WriteLine("Selekcja");
            test.wypisz();
            test.reproduce();
            Console.WriteLine(" 5 pokolenie");
            test.wypisz();

            test.selekcja();
            Console.WriteLine("Selekcja");
            test.wypisz();
            test.reproduce();
            Console.WriteLine(" 6 pokolenie");
            test.wypisz();
            Console.ReadKey();
        }
    }
}
