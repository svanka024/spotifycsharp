using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotifycsharp
{
    internal class Nummer
    {
        public string Naam { get; set; }
        public string Artiest { get; set; }
        public string Album { get; set; }
        public int Duur { get; set; }

        public Nummer(string naam, string artiest, string album)
        {
            Naam = naam;
            Artiest = artiest;
            Album = album;
        }

        public override string ToString()
        {
            return $"{Naam} - {Artiest} ";
        }

        public static List<Nummer> GetSongsForAlbum(int albumIndex)
        {
            switch (albumIndex)
            {
                case 1:
                    return new List<Nummer>()
                    {
                        new Nummer("Take Controle", "The Purge", "Trippin"),
                        new Nummer("Bass Drum", "The Purge", "Trippin"),
                        new Nummer("Planet Circus", "The Purge", "Trippin")

                    };
                case 2:
                    return new List<Nummer>()
                    {
                        new Nummer("Lonely", "Bloodlust", "In Blood We Trust"),
                        new Nummer("Feel Alone", "Bloodlust", "In Blood We Trust"),
                        new Nummer("Get Up", "Bloodlust", "In Blood We Trust")

                    };
                case 3:
                    return new List<Nummer>()
                    { 
                        new Nummer("Controle The Soul", "Wareface", "Rest In Pieces"), 
                        new Nummer("Levitate", "Wareface", "Rest In Pieces"), 
                        new Nummer("Sky Fall", "Wareface", "Rest In Pieces") 
                    };
                default:
                    return new List<Nummer>();
            }
        }
    }
}