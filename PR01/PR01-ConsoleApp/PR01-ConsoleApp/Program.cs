using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR01_ConsoleApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hallo Welt.");

            Console.WriteLine("===================");

            string readLine = Console.ReadLine();
            Console.WriteLine(readLine);

            Console.WriteLine("===================");

            Console.WriteLine("Berechnung Flächeninhalt eines Rechtecks:");
            Console.WriteLine("Breite:");
            int num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Länge:");
            int num2 = Convert.ToInt32(Console.ReadLine());
            int rechteckA = num1 * num2;
            Console.WriteLine("Flächeninhalt des Rechtecks mit Breite "
                + num1 + " und Länge "
                + num2+ " ergibt "
                + rechteckA + ".");

            Console.WriteLine("===================");

            Console.WriteLine("Berechnung Flächeninhalt eines Kreises:");
            Console.WriteLine("Radius:");
            int radius = Convert.ToInt32(Console.ReadLine());
            double kreisA = Math.PI * radius * 2;
            Console.WriteLine("Flächeninhalt des Kreises mit Radius "
                + radius + " ergibt " + kreisA + ".");

            Console.WriteLine("===================");
            Console.WriteLine("...");

            Console.WriteLine("Press Key to close CMD.");
            Console.ReadKey(); //prevents CMD from closing automatically after running
        }
    }
}
