using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotifycsharp
{
    internal class VriendenPagina
    {
        /// <summary>
        /// hardcoded lijst friends word opgehaald. 
        /// </summary>
        private List<string> vrienden = new List<string> { "John", "Jane", "Jack" };
        /// <summary>
        /// methode die input vraagt en vanuit hier kan de user navigeren naar Viewfriends waar vrienden hardcoded staan of ze kunnen kiezen om terug naar het menu te gaan. 
        /// </summary>
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
            Console.WriteLine("Friends List:");
            foreach (string vriend in vrienden)
            {
                Console.WriteLine(vriend);
            }
        }
    }
}
