using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PR02
{
    /// <summary>
    /// 
    /// Klasse zur Verwaltung von Personen
    /// 
    /// </summary>

    internal class Person
    {
        public string Name { get; set; }
        public string Vorname { get; set; }
        public int Alter { get; set; }
        public string Wohnort { get; set; }
        public string Adresse { get; set; }
        public string Geburtsdatum { get; set; }
    
        public Person(string Name, string Vorname, int Alter, string Wohnort, string Adresse, string Geburtsdatum)
        {
            this.Name = Name;
            this.Vorname = Vorname;
            this.Alter = Alter;
            this.Wohnort = Wohnort;
            this.Adresse = Adresse;
            this.Geburtsdatum = Geburtsdatum;
        }

    }
}
