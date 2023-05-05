using System;
using System.Collections.Generic;
using System.Diagnostics;
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
        private string name;
        public string Name
        {
            get { return (name); }
            set
            {
                if (value != null)
                {
                    this.name = value;
                }
            }
        }

        private string vorname;
        public string Vorname
        {
            get { return (vorname); }
            set
            {
                if (value != null)
                {
                    this.vorname = value;
                }
            }
        }

        private int alter;
        public int Alter
        {
            get { return (alter); }
            set
            {
                if (value >= 0)
                {
                    this.alter = value;
                }
            }
        }
        
        private string wohnort;
        public string Wohnort
        {
            get { return (wohnort); }
            set
            {
                if (value != null)
                {
                    this.wohnort = value;
                }
            }
        }

        private string adresse;
        public string Adresse
        {
            get { return (adresse); }
            set
            {
                if (value != null)
                {
                    this.adresse = value;
                }
            }
        }

        private string geburtsdatum;
        public string Geburtsdatum
        {
            get { return (geburtsdatum); }
            set
            {
                if (value != null)
                {
                    this.geburtsdatum = value;
                }
            }
        }

        public Person(string Name, string Vorname, int Alter, string Wohnort, string Adresse, string Geburtsdatum)
        {
            this.name = Name;
            this.vorname = Vorname;
            this.alter = Alter;
            this.wohnort = Wohnort;
            this.adresse = Adresse;
            this.geburtsdatum = Geburtsdatum;
        }


    }
}
