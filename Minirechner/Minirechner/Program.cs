﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Minirechner
{
    
    class Program
    {

        static void Main(string[] args)
        {
            Eingabe();
        }

        static int Sub(int zahl1, int zahl2)
        {
            int erg = zahl1 - zahl2;
            Console.WriteLine("Das Ergebnis der Subtraktion ist: " + erg);
            return erg;
        }

        static int Add(int zahl1, int zahl2)
        {
            int erg = zahl1 + zahl2;
            Console.WriteLine("Das Ergebnis der Addition ist: " + erg);
            return erg;
        }

        static int Mul(int zahl1, int zahl2)
        {
            int erg = zahl1 * zahl2;
            Console.WriteLine("Das Ergebnis der Multiplikation ist: " + erg);
            return erg;
        }

        static int Div(int zahl1, int zahl2)
        {
            int erg = zahl1 / zahl2;
            Console.WriteLine("Das Ergebnis der Division ist: " + erg);
            return erg;           
        }

        static void Eingabe()
        {
            Console.WriteLine("Minirechner by HOFER Lukas 4A EL");

            Console.WriteLine("Bitte gib Zahl1 ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib Zahl2 ein:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWelche Rechenart soll ausgeführt werden?: [+,-,/,*]");
            string menu = Console.ReadLine();

            if (menu == "+")
            {
                Add(zahl1, zahl2);
            }
            if (menu == "-")
            {
                Sub(zahl1, zahl2);
            }
            if (menu == "*")
            {
                Mul(zahl1, zahl2);
            }
            if (menu == "/")
            {
                Div(zahl1, zahl2);
            }
            else
            {
                Console.WriteLine("Bitte seien sie so nett und geben was sinnvolles ein DANKE");
            }

            Console.ReadKey();
        }
    }
}
