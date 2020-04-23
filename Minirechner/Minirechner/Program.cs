using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner
{
    
    class Program
    {
     
        static void Main(string[] args)
        {
            Console.WriteLine("Minirechner by HOFER Lukas 4A EL");
            
            Console.WriteLine("Bitte gib Zahl1 ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib Zahl2 ein:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWelche Rechenart soll ausgeführt werden?: [+,-,/,*]");
            string menu = Console.ReadLine();

            Abfrage(menu, zahl1, zahl2);
            
            Console.ReadKey();
        }
        static void Abfrage(string menu, int zahl1, int zahl2)
        {
            if (menu == "+")
            {
                Addiere(int zahl1, int zahl2);
            }
            else if (menu == "-")
            {
                Subtrahiere(int zahl1, int zahl2);
            }
            else if (menu == "*")
            {
                Multipliziere(int zahl1, int zahl2);
            }
            else if (menu == "/")
            {
                Dividiere(int zahl1, int zahl2);
            }
            else
            {
                Console.WriteLine("Bitte seien sie so nett und geben was sinnvolles ein DANKE");
            }

        }

       

       
    }
}
