 using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplan
{
    public class Speise
    {
        //Objektvariablen
        private string bezeichnung;
        private char speiseart;
        private double preis;
        private List<Zutat> zutaten = new List<Zutat>();
        private string bildPfad;

        //Konstruktoren
        public Speise()
        {

        }

        public Speise(string bezeichnung, double preis, char speiseart, string bildPfad)
        {
            this.bezeichnung = bezeichnung;
            this.preis = preis;
            this.speiseart = speiseart;
            this.bildPfad = bildPfad;
        }

        //Properties

        public string Bezeichnung { get; set; }
        public double Preis { get; set; }
        public char Speiseart { get; set; }
        public List<Zutat> Zutaten { get; set; }
        public string BildPfad { get; set; }
    }
}
