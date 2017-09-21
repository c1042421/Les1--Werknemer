using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace oefWerknemer
{
    class Werknemer
    {
        private string _naam;
        private double _verdiensten;
        private string _voornaam;

        public string Naam { get => _naam; set => _naam = value; }
        public double Verdiensten { get => _verdiensten; set => _verdiensten = value; }
        public string Voornaam { get => _voornaam; set => _voornaam = value; }
        public string VolledigeWeergave { get => string.Format("{0} {1} {2} €\n", Naam.PadRight(20), Voornaam.PadRight(20), Verdiensten.ToString().PadLeft(20)); }

        public Werknemer(string naam, string voornaam, double verdiensten)
        {
            this.Naam = naam;
            this.Voornaam = voornaam;
            this.Verdiensten = verdiensten;
        }
    }
}
