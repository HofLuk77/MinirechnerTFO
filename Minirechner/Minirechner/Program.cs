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
<<<<<<< HEAD
//<<<<<<< HEAD
//<<<<<<< HEAD
//=======
=======
            Ausgabe();
        }
        static void Ausgabe()
        {
>>>>>>> Eingabe
            Console.WriteLine("Minirechner by HOFER Lukas 4A EL");

            Console.WriteLine("Bitte gib Zahl1 ein:");
            int zahl1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Bitte gib Zahl2 ein:");
            int zahl2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("\nWelche Rechenart soll ausgeführt werden?: [+,-,/,*]");
            string menu = Console.ReadLine();

<<<<<<< HEAD
            Abfrage(menu, zahl1, zahl2);
            
            Console.ReadKey();
        }

        static void Abfrage(string menu, int zahl1, int zahl2)
        {
            if (menu == "+")
            {
                Addiere(zahl1, zahl2);
=======
            if (menu == "+")
            {
                Add(zahl1, zahl2);  
>>>>>>> Eingabe
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
<<<<<<< HEAD
//>>>>>>> Eingabe

=======
          
            Console.ReadKey();
>>>>>>> Eingabe
        }

       

       
//=======
            
     //   }

//<<<<<<< HEAD
        static int Addiere(int zahl1, int zahl2)
        {
            double erg = zahl1 + zahl2;
            Console.WriteLine("Das Ergebnis ist: " + erg);
        }

//<<<<<<< HEAD
//>>>>>>> Addieren
//=======
        static int Subtrahiere(int zahl1, int zahl2)
        {
            double erg = zahl1 - zahl2;
            Console.WriteLine("Das Ergebnis ist: " + erg);
        }
//<<<<<<< HEAD

        
//>>>>>>> Subtrahieren
//=======
        static int Dividiere(int zahl1, int zahl2)
        {
            double erg = zahl1 / zahl2;
            Console.WriteLine("Das Ergebnis ist: " + erg);
        }

//>>>>>>> Dividieren
//=======
        static int Multiplizieren(int zahl1, int zahl2)
        {
            double erg = zahl1 * zahl2;
            Console.WriteLine("Das Ergebnis ist: " + erg);
        }

//>>>>>>> Multiplizieren
    }
}
