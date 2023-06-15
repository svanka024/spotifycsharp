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
                        Console.WriteLine("naar albumpagina..");
                        AlbumPagina albumPagina = new AlbumPagina();
                        albumPagina.display();
                        break;

                    case 2:
                        Console.WriteLine("naar Vriendenlijstpagina..");
                        VriendenPagina vriendenPagina = new VriendenPagina();
                        vriendenPagina.display();
                        break;

                    case 3:
                        Console.WriteLine("naar Playlistpagina..");
                        PlaylistPagina
                }
            }

        }

    }
}
