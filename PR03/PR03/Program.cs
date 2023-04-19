using PR02;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR01_ConsoleApp
{
    /*
     * Kennenlernen Arrays, Testen String-Operationen, DateTime Class, Verknüpfen von Strings
     */
    internal class Program
    {
        private static string str; //use to store any string

        static void Main(string[] args)
        {
            /*
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
            

            Console.WriteLine("===================");

            Console.WriteLine("Gebe einen String ein, auf welchem String Operationen durchgeführt werden sollen: ");
            string str = Console.ReadLine();

            removeWhitespacesAtStringStart(str);

            Console.WriteLine("Gebe einen Substring ein...");
            string substr = Console.ReadLine();

            tellIfContainsSubstring(str, substr);

            Console.WriteLine("Länge der Zeichenkette: " + str.Length);

            Console.WriteLine("Gebe ein Zeichen zur Indexbestimmung des ersten Auftretens des Zeichens ein:");
            char ch = Console.ReadKey().KeyChar;
            Console.WriteLine();

            tellIndexOfCharInString(str, ch);

            Console.WriteLine("Trennung der Zeichenkette anhand der existierenden Vokale...");
            char[] separationPoints = { 'a', 'e', 'i', 'o', 'u' };
            string[] substrings = str.Split(separationPoints);

            printStringArrayToConsole(substrings);

            Console.WriteLine("===================");
            

            var now = DateTime.Now;
            var date = now.ToString("dd.MM.yyyy");
            var time = now.ToShortTimeString(); //short time string format: HH:MM
            Console.WriteLine("Heute ist der: " + date);
            Console.WriteLine("Uhrzeit der Ausführung: " + time);

            Console.WriteLine("Datum vor 345 Tagen: " + now.AddDays(-345).ToString("dd.MM.yyyy"));
            */

            Console.WriteLine("===================");

            Console.WriteLine("Geben Sie eine Zeichenkette ein...");
            str = Console.ReadLine();

            int loopCounts = 1000;
            Console.WriteLine("Zeichenkette wird " + loopCounts + " an sich selbst gehangen:");

            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine(duplicateString(str, loopCounts));
            sw.Stop();
            Console.WriteLine("Vergangene Zeit der Duplikation mit Schleife: " + sw.ElapsedMilliseconds + "ms.");

            sw = Stopwatch.StartNew();
            Console.WriteLine(duplicateStringAppend(str, loopCounts));
            sw.Stop();
            Console.WriteLine("Vergangene Zeit der Duplikation mit StringBuilder und Append-Funktion: " + sw.ElapsedMilliseconds + "ms.");


        }


        private static string duplicateStringAppend(string str, int num)
        {
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < num; i++)
            {
                sb.Append(str + " ");
            }
            return sb.ToString();
        }

        /// <summary>
        /// 
        /// Adds String str to str for num times in loop
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="num"></param>
        /// <returns></returns>
        private static string duplicateString(string str, int num)
        {
            string duplStr = "";
            for(int i = 0; i < num; i++)
            {
                duplStr += str + " ";
            }
            return duplStr;
        }

        /// <summary>
        /// 
        /// Removes Whitespaces from beginning of the string if first letter is whitespace
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <returns></returns>
        private static string removeWhitespacesAtStringStart(string str)
        {
            if(char.IsWhiteSpace(str, 0))
            {
                return str.TrimStart();
            } else
            {
                return str;
            }
            
        }

        /// <summary>
        /// 
        /// Prints Array of String to Console
        /// 
        /// </summary>
        /// <param name="strs"></param>
        private static void printStringArrayToConsole(string[] strs)
        {
            for(int i = 0; i < strs.Length; i++)
            {
                Console.WriteLine(strs[i]);
            }
        }

        /// <summary>
        /// 
        /// Writes Index of Char in String to Console
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="ch"></param>
        private static void tellIndexOfCharInString(string str, char ch)
        {
            str = str.ToLower();
            int pos = str.IndexOf(ch); 
            if(pos == -1)
            {
                Console.WriteLine("Angegebenes Zeichen ist in Zeichenkette '" + str + "' nicht enthalten.");
            } else
            {
                pos += 1; //pos starts with 0 -> +1 -> pos starts with 1 .> shows 'right' position
                Console.WriteLine("Zeichen an Stelle " + pos + " erstmalig in Zeichenkette '" + str + "' zu finden.");
            }
        }

        /// <summary>
        /// 
        /// Writes if string contains substring to Console
        /// 
        /// </summary>
        /// <param name="str"></param>
        /// <param name="substr"></param>
        private static void tellIfContainsSubstring(string str, string substr)
        {
            if (str.Contains(substr, StringComparison.CurrentCultureIgnoreCase))
            {
                Console.WriteLine("String " + str + " enthält Substring " + substr + ".");
            } else
            {
                Console.WriteLine("Substring " + substr + " in String " + str + " nicht enthalten.");
            }
        }


    }
}
