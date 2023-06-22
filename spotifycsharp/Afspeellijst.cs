using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpotifyApp.playlists
{

    internal class Afspeellijst
    {
        public string Naam { get; set; }
        public List<Nummer> Nummers { get; set; }
        public void AddNummer(Nummer nummer)
        {
            Nummer.Add(nummer);
        }
        public Afspeellijst(string naam)
        {
            Naam = naam;

            // voegt hardcode nummers begin nummer toe
            Nummer = new List<Nummer>()
        {
            new nummer("TAKE CONTROL", "The Purge", "Trippin"),
            new nummer("Lonely", "Bloodlust", "In Blood We Trust"),
            new nummer("Control the soul - Multilator remix", "Warface", "Rest in pieces"),
        };
        }
    }



}