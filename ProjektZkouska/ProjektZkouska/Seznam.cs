using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektZkouska
{
    class Seznam
    {
        List<Pojistenec> pojistenci = new List<Pojistenec>();

        public void PridejPojistence()
        {
            Console.WriteLine("Zadejte jméno pojistěnce:");
            string jmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni = Console.ReadLine();
            Console.WriteLine("Zadejte telefonní číslo:");
            int telefon = int.Parse(Console.ReadLine());
            Console.WriteLine("Zadejte věk:");
            int vek = int.Parse(Console.ReadLine());

            pojistenci.Add(new Pojistenec(jmeno, prijmeni, telefon, vek));
            Console.WriteLine();
            Console.WriteLine("Data byla ulozena. Pokracujte libovolnou klávesou...");
            Console.ReadKey();
        }
        public void VypisVsechnyPojistence()
        {

                foreach (Pojistenec pojistenec in pojistenci)
                {
                    Console.WriteLine(pojistenec);
                }
            
            Console.WriteLine();
            Console.WriteLine("Pokracujte libovolnou klávesou...");
            Console.ReadKey();
        }
        public void VypisHledanehoPojistence()
        {
            Console.WriteLine("Zadejte jméno pojistěného:");
            string hledaneJmeno = Console.ReadLine();
            Console.WriteLine("Zadejte příjmení:");
            string hledanePrijmeni = Console.ReadLine();

            foreach(Pojistenec pojistenecHledany in pojistenci)
            {
                if ((pojistenecHledany.Jmeno == hledaneJmeno) && (pojistenecHledany.Prijmeni == hledanePrijmeni))
                {
                    Console.WriteLine(pojistenecHledany);
                }
            }

            Console.WriteLine();
            Console.WriteLine("Pokračujte libovolnou klávesou...");
            Console.ReadKey();
        }        
    }
}
