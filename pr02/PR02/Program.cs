using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR01_ConsoleApp
{
    internal class Program
    {
        static int rechteckA;

        static void Main(string[] args)
        {
          
            Console.WriteLine("===================");

            Console.WriteLine("Berechnung Flächeninhalt eines Rechtecks:");
            Console.WriteLine("Breite:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Länge:");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Über Rückgabewert der Methode: " + berechneFlaecheninhaltMitRueckgabe(num1, num2));

            berechneFlaecheninhalt(num1, num2);
            Console.WriteLine("Über Zuweisung an globale Variable: " + rechteckA);

            Console.WriteLine("===================");
            

        }

        /// <summary>
        /// 
        /// Berechnet Flächeninhalt eines Rechtecks auf Grundlage uebergebener Werte
        /// 
        /// </summary>
        /// 
        /// <param name="a"> Breite des Rechtecks </param>
        /// <param name="b"> Laenge des Rechtecks </param>
        public static void berechneFlaecheninhalt(int a, int b)
        {
            rechteckA = a * b;
        }

        /// <summary>
        /// 
        /// Berechnet Flaecheninhalt eines Rechtecks auf Grundlage uebergebener Werte
        /// mit Rueckgabewert
        /// 
        /// </summary>
        /// <param name="a"> Breite des Rechtecks </param>
        /// <param name="b"> Laenge des Rechtecks </param>
        /// <returns> Flaecheninhalt des Rechtecks </returns>
        public static int berechneFlaecheninhaltMitRueckgabe(int a, int b)
        {
            return a * b;
        }

    }
}
