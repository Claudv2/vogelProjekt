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
        public string ImBesitz { get; set; }
        public double Kaufpreis { get; set; }
        public string Verkaeufer { get; set; }
        public string Schaetzpreis { get; set; }
        public string Hersteller { get; set; }
        public string ArtNr { get; set; }
        public string SetNr { get; set; }
        public string Bezeichung { get; set; }
        public string Farbe { get; set; }
        public string Bemerkung { get; set; }
        public string Bahngesellschaft { get; set; }
        public string Loktyp { get; set; }
        public int Loknummer { get; set; }
        public string Veroeffentlichung { get; set;}
        public Rollmaterial(
            string paramImBesitz,
            double paramKaufpreis,
            string paramVerkaeufer,
            string paramSchaetzpreis,
            string paramHersteller,
            string paramArtNr,
            string paramSetNr,
            string paramBezeichung,
            string paramBemerkung,
            string paramFarbe,
            string paramBahngesellschaft,
            string paramLoktyp,
            int paramLoknummer,
            string paramVeroeffentlichung
        ) { 
            id = new Guid(); 
            ImBesitz = paramImBesitz;
            Kaufpreis = paramKaufpreis;
            Verkaeufer = paramVerkaeufer;
            Schaetzpreis = paramSchaetzpreis;
            Hersteller = paramHersteller;
            ArtNr = paramArtNr;
            SetNr = paramSetNr;
            Bezeichung = paramBezeichung;
            Bemerkung = paramBemerkung;
            Farbe = paramFarbe;
            Bahngesellschaft = paramBahngesellschaft;
            Loktyp = paramLoktyp;
            Loknummer = paramLoknummer;
            Veroeffentlichung = paramVeroeffentlichung;
        }

    }

}