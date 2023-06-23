using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotifycsharp
{
    internal class AlbumPagina
    {
        private List<Nummer> nummer = new List<Nummer>();
        private static List<Afspeellijst> afspeellijst = new List<Afspeellijst>();



        public void Display()
        {
            int optie = 0;

            do
            {
                Console.WriteLine("kies een album:");
                Console.WriteLine("1. The Purge/Trippin");
                Console.WriteLine("2. Bloodlust/In Blood We Trust");
                Console.WriteLine("3. Wareface/Rest In Pieces");
                Console.WriteLine("0. terug naar begin");
                Console.Write("Album: ");
                optie = int.Parse(Console.ReadLine());

                switch (optie)
                {
                    case 1:
                        DisplayNummersVoorAlbum("The Purge/Trippin", Nummer.GetNummersVoorAlbum(1));
                        break;
                    case 2:
                        DisplayNummersVoorAlbum("Bloodlust/In Blood We Trust", Nummer.GetNummersVoorAlbum(2));
                        break;
                    case 3:
                        DisplayNummersVoorAlbum("Wareface/Rest In Pieces", Nummer.GetNummersVoorAlbum(3));
                        break;  
                    case 0:
                        Console.WriteLine("terug naar begin");
                        break;
                    default:
                        Console.WriteLine("geen geldige waarden");
                        break;
                }

                Console.WriteLine();
            } while (optie != 0);
        }

        private void DisplayNummersVoorAlbum(string albumNaam, List<Nummer> nummers)
        {
            int optie = 0;
            bool loopNummer = false;

            do
            {
                Console.WriteLine($"nummer uit {albumNaam}");
                Console.WriteLine();

                for (int i = 0; i < nummers.Count; i++)
                {
                    Console.WriteLine($"{i + 1}. {nummers[i].ToString()}");
                }

                Console.WriteLine("0. terug naar album..");
                Console.Write("nummer: ");
                optie = int.Parse(Console.ReadLine());

                if (optie == 0)
                {
                    break;
                }

                nummer selectedNummer = nummers[optie - 1];

                Console.WriteLine($"nummer: {selectedNummer.ToString()}");
                Console.WriteLine("--------------------------------------------");

                do
                {
                    Console.WriteLine("kies een optie:");
                    Console.WriteLine("1. speel nummer af");
                    Console.WriteLine("2. Pauzeer nummer");
                    Console.WriteLine("3. herhaal nummer");
                    Console.WriteLine("4. nummer toevoegen aan afspeellijst");
                    Console.WriteLine("5. terug naar album");
                    Console.Write("Optie: ");
                    optie = int.Parse(Console.ReadLine());

                    switch (optie)
                    {
                        case 1:
                            Console.WriteLine("nummer word nu afgespeeld");
                            break;
                        case 2:
                            Console.WriteLine("nummer is nu gepauzeerd");
                            break;
                        case 3:
                            if (!loopNummer)
                            {
                                Console.WriteLine("nummer word herhaald");
                                loopNummer = true;
                            }
                            else
                            {
                                Console.WriteLine("nummer word niet herhaald");
                                loopNummer = false;
                            }
                            break;
                        case 4:
                            Console.WriteLine("toevoegen aan afspeellijst");
                            VoegNummerAfspeellijst(selectedNummer);
                            break;


                        case 5:
                            Console.WriteLine("terug naar album");
                            break;
                        default:
                            Console.WriteLine("geen waarden gevonden");
                            break;
                    }

                    Console.WriteLine();
                } while (optie != 5);
            } while (true);
        }

        public void AddNummerToAfspeellijst(Nummer nummer)
        {
            Console.WriteLine("welke afspeellijst moet het nummer bij");

            if (afspeellijst.Count == 0)
            {
                Console.WriteLine("je hebt geen afspeellijsten");
                return;
            }

            Console.WriteLine("afspeellijst");
            for (int i = 0; i < afspeellijst.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {afspeellijst[i].Naam}");
            }

            Console.Write("afspeellijst naam");
            string afspeellijstNaam = Console.ReadLine();

            Afspeellijst selectedAfspeellijst = null;

            foreach (Afspeellijst p in afspeellijst)
            {
                if (p.Naam == afspeellijstNaam)
                {
                    selectedAfspeellijst = p;
                    break;
                }
            }

            if (selectedAfspeellijst == null)
            {
                Console.WriteLine("afspeellijst niet gevonden");
                return;
            }

            // afspeellijst maken als die er niet is 
            if (selectedAfspeellijst.Nummers == null)
            {
                selectedAfspeellijst.Nummers = new List<Nummer>();
            }

            selectedAfspeellijst.Nummers.Add(nummer);

            Console.WriteLine($"{nummer.Naam}/{nummer.Artiest} is toegevoegd tot {selectedAfspeellijst.Naam}");
        }

    }
}
