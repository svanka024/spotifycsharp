using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotifycsharp
{
    internal class AfspeellijstPagina
    {
        private static List<Afspeellijst> afspeellijsten = new List<Afspeellijst>();

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
                        MaakNieuweAfspeellijst();
                        break;

                    case 2:
                        BekijkAfspeellijst();
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
        private static void MaakNieuweAfspeellijst()
        {
            Console.WriteLine("Naam van je nieuwe afspeellijst:");
            string afspeellijstNaam = Console.ReadLine();

            Afspeellijst nieuwAfspeellijst = new Afspeellijst(afspeellijstNaam);
            Afspeellijsten.Add(nieuwAfspeellijst);

            Console.WriteLine($"Nieuwe afspeellijst '{afspeellijstNaam}' is gemaakt");
            Console.WriteLine();

            Console.WriteLine($"{nieuwAfspeellijst.Naam}");
            Console.WriteLine();

            Console.WriteLine($"{nieuwAfspeellijst.Nummer.Count + 1}. Ga terug naar afspeellijst pagina");
            Console.Write("Nummer: ");
            int option = int.Parse(Console.ReadLine());

            if (option == nieuwAfspeellijst.Nummer.Count + 1)
            {
                Console.WriteLine();
                return;
            }

            if (option < 1 || option > nieuwAfspeellijst.Nummer.Count)
            {
                Console.WriteLine("Geen geldige optie.");
                Console.WriteLine();
                return;
            }
        }

        private static void VerwijderAfspeellijst(List<Afspeellijst> afspeellijsten)
        {
            Console.WriteLine("Welke afspeellijst wil je verwijderen?");
            Console.WriteLine("Afspeellijst: ");
            int optie = int.Parse(Console.ReadLine());

            if (optie < 1 || optie > afspeellijst.Count)
            {
                Console.WriteLine("Geen geldige optie.");
                Console.WriteLine();
                return;
            }
            Afspeellijst afspeellijstVerwijder = afspeellijst[optie - 1];
            afspeellijst.Remove(afspeellijstVerwijder);

            Console.WriteLine($"Afspeellijst '{afspeellijstVerwijder.Naam}' is verwijderd.");
        }

        private static void BekijkAfspeellijst()
        {
            Console.WriteLine("Playlist Overzicht:");
            Console.WriteLine();

            if (afspeellijsten.Count == 0)
            {
                Console.WriteLine("Er zijn geen playlist beschikbaar.");
                Console.WriteLine();
                return;
            }
            for (int i = 0; i < afspeellijst.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {afspeellijsten[i].Naam}");
            }

            Console.WriteLine($"{afspeellijsten.Count + 1}. Verwijder een playlist");
            Console.WriteLine($"{afspeellijsten.Count + 2}. Ga terug naar het menu");
            Console.Write("Playlist: ");
            int optie = int.Parse(Console.ReadLine());

            if (optie == afspeellijsten.Count + 2)
            {
                Console.WriteLine();
                return;
            }

            if (optie < 1 || optie > afspeellijsten.Count + 1)
            {
                Console.WriteLine("Geen geldige optie.");
                Console.WriteLine();
                return;
            }

            if (optie == afspeellijsten.Count + 1)
            {
                VerwijderPlaylist(afspeellijsten);
                Console.WriteLine();
                return;
            }

            Afspeellijst geselecteerdeAfspeellijst = afspeellijsten[optie - 1];

            Console.WriteLine();
            Console.WriteLine($"{geselecteerdeAfspeellijst.Naam}:");
            Console.WriteLine();

            for (int i = 0; i < geselecteerdeAfspeellijst.Liedje.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {geselecteerdeAfspeellijst.Nummers[i].ToString()}");
            }

            Console.WriteLine($"{geselecteerdeAfspeellijst.Nummer.Count + 1}. Ga terug naar het menu");
            Console.Write("Liedje: ");
            optie = int.Parse(Console.ReadLine());

            if (optie == geselecteerdeAfspeellijst.Nummer.Count + 1)
            {
                Console.WriteLine();
                return;
            }

            if (optie < 1 || optie > geselecteerdeAfspeellijst.Nummer.Count)
            {
                Console.WriteLine("Geen geldige optie");
                Console.WriteLine();
                return;
            }

            Nummer geselecteerdeNummer = geselecteerdeAfspeellijst.Nummer[optie - 1];

            Console.WriteLine();
            Console.WriteLine($"Nu speeld '{geselecteerdeNummer.ToString()}' van '{geselecteerdeAfspeellijst.Nummer}'!");
            Console.WriteLine();

        }
    }
}
