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

                }
            }
        }
    }
}
    
