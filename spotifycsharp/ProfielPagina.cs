using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace spotifycsharp
{
    internal class ProfielPagina
    {
        public void DisplayProfielPagina()
        {
            Console.WriteLine("Welkom, jasper van uden");
            Console.WriteLine("Je abonement eindigd op: " + DateTime.Now.AddDays(30).ToString("dd/MM/yyyy"));
        }
    }
}