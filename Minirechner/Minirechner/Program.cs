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
        }

        static int Div(int zahl1, int zahl2)
        {
            int erg = zahl1 / zahl2;
            Console.WriteLine("Das Ergebnis der Division ist: " + erg);
            return erg;
        }

    }
}
