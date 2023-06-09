﻿using PR02;
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
            int breite = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Länge:");
            int laenge = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Über Rückgabewert der Methode: " + berechneFlaecheninhaltMitRueckgabe(breite, laenge));

            berechneFlaecheninhalt(breite, laenge);
            Console.WriteLine("Über Zuweisung an globale Variable: " + rechteckA);

            Console.WriteLine("===================");

            Console.WriteLine("Berechnung Flächeninhalt eines Quadrats:");
            Console.WriteLine("Länge der Seiten:");
            int quadratSeite = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Über Rückgabewert der Methode: " + berechneFlaecheninhalt(quadratSeite));

            Console.WriteLine("===================");

            Console.WriteLine("Erstelle Personen...");

            Person[] personen = new Person[]
            {
                new Person("Mustermann", "Max", 21, "Mittweida", "Technikumplatz 17", "23.03.2002"),
                new Person("Müller", "Claudia", 23, "Chemnitz", "Moritzstrasse 32", "23.07.2000"),
                new Person("Mustermann", "Max", 21, "Mittweida", "Technikumplatz 17", "23.03.2002"),
            };
                
            Console.WriteLine(personen.Length + " Person(en) wurde(n) erstellt:");

            for(int i = 0; i < personen.Length; i++)
            {
                Console.WriteLine("Person " + i + ":");
                Console.WriteLine(
                    "Name, Vorname: " + personen[i].Name + ", " + personen[i].Vorname + "\n"
                    + "Geburtsdatum, Alter: " + personen[i].Geburtsdatum + ", " + personen[i].Alter + "\n"
                    + "Adresse: " + personen[i].Wohnort + ", " + personen[i].Adresse + "\n");
            }

            Console.WriteLine("Press Key to close CMD.");
            Console.ReadKey(); //prevents CMD from closing automatically after running

            ///TODO: Moegliche Erweiterung: Hinzufuegen erstellter Personen zu Array
            ///und Ausgabe der erstellten Personen, indem Array durchlaufen wird
        }

        /// <summary>
        /// 
        /// Berechnet Flaecheninhalt eines Quadrats auf Grundlage uebergebener Werte
        /// 
        /// </summary>
        /// <param name="seitenlaenge"> Seitelaenge des Quadrats </param>
        /// <returns> Flaecheninhalt des Qudrats </returns>
        public static int berechneFlaecheninhalt(int seitenlaenge)
        {
            return seitenlaenge * seitenlaenge;
        }

        /// <summary>
        /// 
        /// Berechnet Flaecheninhalt eines Rechtecks auf Grundlage uebergebener Werte
        /// 
        /// </summary>
        /// 
        /// <param name="breite"> Breite des Rechtecks </param>
        /// <param name="laenge"> Laenge des Rechtecks </param>
        public static void berechneFlaecheninhalt(int breite, int laenge)
        {
            rechteckA = breite * laenge;
        }

        /// <summary>
        /// 
        /// Berechnet Flaecheninhalt eines Rechtecks auf Grundlage uebergebener Werte
        /// mit Rueckgabewert
        /// 
        /// </summary>
        /// <param name="breite"> Breite des Rechtecks </param>
        /// <param name="laenge"> Laenge des Rechtecks </param>
        /// <returns> Flaecheninhalt des Rechtecks </returns>
        public static int berechneFlaecheninhaltMitRueckgabe(int breite, int laenge)
        {
            return breite * laenge;
        }

    }
}
