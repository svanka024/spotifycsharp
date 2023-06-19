using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotifycsharp
{
    internal class PlaylistPagina
    {
        private static List<Playlist> Playlists = new List<Playlist>();

        public void DisplayPlaylistPagina()
        {
            int option = 0;

            do
            {
                Console.WriteLine("kies een optie:");
                Console.WriteLine("1, Maak nieuwe playlist.");
                Console.WriteLine("2, Bekijk playlist.");
                Console.WriteLine("3, Ga terug.");
                Console.Write("Option: ");
                option = int.Parse(Console.ReadLine());

                switch (option)
                {
                    case 1:
                        MaakNieuwePlaylist();
                        break;

                    case 2:
                        BekijkPlaylist();
                        break;

                    case 3:
                        Console.WriteLine("Terug naar het menu...");
                        break;

                    default:
                        Console.WriteLine("Geen geldige keuze");

                }
                Console.WriteLine();
            } while (option != 3);
        }
        private static void MaakNieuwePlaylist()
        {
            Console.WriteLine("Naam van je nieuwe playlist:");
            string playlistNaam = Console.ReadLine();

            Playlist nieuwPlaylist = new Playlist(playlistNaam);
            Playlists.Add(nieuwPlaylist);

            Console.WriteLine($"Nieuwe playlist '{playlistNaam}' is gemaakt");
            Console.WriteLine();

            Console.WriteLine($"{nieuwPlaylist.Naam}");
            Console.WriteLine();

            Console.WriteLine($"{nieuwPlaylist.Liedje.Count + 1}. Ga terug naar Playlist pagina");
            Console.Write("liedje: ");
            int option = int.Parse(Console.ReadLine());

            if (option == nieuwPlaylist.Liedje.Count + 1)
            {
                Console.WriteLine();
                return;
            }

            if (option < 1 || option > nieuwPlaylist.Liedje.Count)
            {
                Console.WriteLine("Geen geldige optie.");
                Console.WriteLine();
                return;
            }
        }

        private static void VerwijderPlaylist(List<Playlist> playlists)
        {
            Console.WriteLine("Welke playlist wil je verwijderen?");
            Console.WriteLine("Playlist: ");
            int optie = int.Parse(Console.ReadLine());

            if (optie < 1 || optie > playlists.Count)
            {
                Console.WriteLine("Geen geldige optie.");
                Console.WriteLine();
                return;
            }
            Playlist playlistVerwijder = playlists[optie - 1];
            playlists.Remove(playlistVerwijder);

            Console.WriteLine($"Playlist '{playlistVerwijder.Naam}' is verwijderd.");
        }

        private static void BekijkPlaylist()
        {
            Console.WriteLine("Playlist Overzicht:");
            Console.WriteLine();

            if (playlists.Count == 0)
            {
                Console.WriteLine("Er zijn geen playlist beschikbaar.");
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < playlists.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {playlists[i].Naam}");
            }

            Console.WriteLine($"{playlists.Count + 1}. Verwijder een playlist");
            Console.WriteLine($"{playlists.Count + 2}. Ga terug naar het menu");
            Console.Write("Playlist: ");
            int optie = int.Parse(Console.ReadLine());

            if (optie == playlists.Count + 2)
            {
                Console.WriteLine();
                return;
            }

            if (optie < 1 || optie > playlists.Count + 1)
            {
                Console.WriteLine("Geen geldige optie.");
                Console.WriteLine();
                return;
            }

            if (optie == playlists.Count + 1)
            {
                VerwijderPlaylist(playlists);
                Console.WriteLine();
                return;
            }

            Playlist geselecteerdePlaylist = playlists[optie - 1];

            Console.WriteLine();
            Console.WriteLine($"{geselecteerdePlaylist.Naam}:");
            Console.WriteLine();

            for (int i = 0; i < geselecteerdePlaylist.Liedje.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {geselecteerdePlaylist.Songs[i].ToString()}");
            }

            Console.WriteLine($"{geselecteerdePlaylist.Liedje.Count + 1}. Ga terug naar het menu");
            Console.Write("Liedje: ");
            optie = int.Parse(Console.ReadLine());

            if (optie == geselecteerdePlaylist.Liedje.Count + 1)
            {
                Console.WriteLine();
                return;
            }

            if (optie < 1 || optie > geselecteerdePlaylist.Liedje.Count)
            {
                Console.WriteLine("Geen geldige optie");
                Console.WriteLine();
                return;
            }

            Liedje geselecteerdeLiedje = geselecteerdePlaylist.Liedje[optie - 1];

            Console.WriteLine();
            Console.WriteLine($"Nu speeld '{geselecteerdeLiedje.ToString()}' van '{geselecteerdePlaylist.Liedje}'!");
            Console.WriteLine();

        }
    }
}
    
