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
            Console.WriteLine("\nWelche Rechenart soll ausgeführt werden?: [+,-,/,*]");
            string menu = Console.ReadLine();

            Console.WriteLine("Bitte gib Zahl1 ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib Zahl2 ein:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());
            
            Console.ReadKey();
        }

       

       
    }
}
