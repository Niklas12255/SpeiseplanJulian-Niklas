using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Speiseplan
{
    public class Zutat
    {
        //Objektvariablen
        private string bezeichnung;
        private string einheit;
        private string kategorie;
        private List<Speise> speise;

        //Konstruktoren
        public Zutat()
        {

        }

        public Zutat(string bezeichnung, string einheit, string kategorie)
        {

        }

        public string Bezeichung { get; set; }
        public string Einheit { get; set; }
        public string Kategorie { get; set; }
        public List<Speise> Speise { get; set; }

    }
}
