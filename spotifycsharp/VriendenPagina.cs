using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotifycsharp
{
    internal class VriendenPagina
    {
        private List<string> vrienden = new List<string> { "John", "Jane", "Jack" };
        public void Display()
        {

            int optie = 0;

            do
            {
                Console.WriteLine("Sececteer een optie");
                Console.WriteLine("1. Mijn vrienden");
                Console.WriteLine("2. Terug naar menu");
                Console.Write("Optie: ");
                optie = int.Parse(Console.ReadLine());


                switch (optie)
                {
                    case 1:
                        Console.WriteLine("Mijn vrienden..");
                        BekijkVrienden();
                        break;
                    case 2:
                        Console.WriteLine("Terug naar het menu");
                        optie = 2;
                        break;
                    default:
                        Console.WriteLine("Onjuiste Keuze.");
                        break;
                }

                Console.WriteLine();
            } while (optie != 2);
        }


        private void BekijkVrienden()
        {
            Console.WriteLine("Vriendenlijst:");
            foreach (string vriend in vrienden)
            {
                Console.WriteLine(vriend);
            }
        }
    }
}
