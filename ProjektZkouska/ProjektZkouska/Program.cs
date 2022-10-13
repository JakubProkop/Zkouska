using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZkouska
{
    class Program
    {
        static void Main(string[] args)
        {
            Seznam seznam = new Seznam();

            bool konec = true;

            while (konec)
            {
                Console.Clear();
                Console.WriteLine("---------------------------");
                Console.WriteLine("Evidence pojistěných");
                Console.WriteLine("---------------------------");
                Console.WriteLine();
                Console.WriteLine("Vyberte si akci:");
                Console.WriteLine("1 - Přidat nového pojištěnce");
                Console.WriteLine("2 - Vypsat všechny pojistěnce");
                Console.WriteLine("3 - Vyhledat pojistěného");
                Console.WriteLine("4 - Konec");
                int volba = int.Parse(Console.ReadLine());
                switch (volba)
                {
                    case 1:
                        seznam.PridejPojistence();
                        break;
                    case 2:
                        seznam.VypisVsechnyPojistence();
                        break;
                    case 3:
                        seznam.VypisHledanehoPojistence();
                        break;
                    case 4:
                        konec = false;
                        break;

                }
            }
        }
    }
}