namespace spotifycsharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int optie = 0;

            do
            {
                Console.WriteLine("Selecteer je optie!");
                Console.WriteLine("1, Playlist");
                Console.WriteLine("2, Vriendenlijst");
                Console.WriteLine("3, Album");
                Console.WriteLine("4, Profiel");
                Console.WriteLine("0, Stop");
                Console.WriteLine("Optie: ");
                optie = int.Parse(Console.ReadLine());

                switch (optie) 
                {
                    case 1:
                        Console.WriteLine("naar Playlistpagina..");
                        PlaylistPagina playlistPagina = new PlaylistPagina();
                        playlistPagina.DisplayPlaylistPagina();
                        break;

                    case 2:
                        Console.WriteLine("naar Vriendenlijstpagina..");
                        VriendenPagina vriendenPagina = new VriendenPagina();
                        vriendenPagina.Display();
                        break;

                    case 3:                        
                        Console.WriteLine("naar albumpagina..");
                        AlbumPagina albumPagina = new AlbumPagina();
                        albumPagina.Display();
                        break;

                    case 4:
                        Console.WriteLine("naar profielpagina..");
                        ProfielPagina profielProfiel = new ProfielPagina():
                        profielPagina.Display();
                        break;

                    case 0:
                        Console.WriteLine("stop..");
                        break;

                    default:
                        Console.WriteLine("geen geldige waarde.");
                        break;
                }


            } while (optie != 0);

            Console.WriteLine("klik een toets om te stoppen.");
            Console.ReadKey();

        }

    }
}
