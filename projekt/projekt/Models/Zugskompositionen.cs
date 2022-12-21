using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Web;

namespace projekt.Models
{
    public class Zugskompositionen
    {
        public Guid id;

        public Rollmaterial locke;
        public Zugskompositionen(Rollmaterial locke1) { 
            id = new Guid(); 
            locke = locke1; 
        }
        
    }

    public class Rollmaterial
    {
        public Guid id;
        public Rollmaterial() { id = new Guid(); }
        public string ImBesitz { get; set; }
        public string Kaufpreis { get; set; }
        public string Verkaeufer { get; set; }
        public string Schaetzpreis { get; set; }
        public string Hersteller { get; set; }
        public string ArtNr { get; set; }
        public string SetNr { get; set; }
        public string Bezeichung { get; set; }
        public string Bemerkung { get; set; }
        public string Bahngesellschaft { get; set; }
        public string Loktyp { get; set; }
        public string Loknummer { get; set; }
        public string Veroeffentlichung { get; set; }
    }

}