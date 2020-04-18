using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Samochody
{
    class Samochod : Pojazd, IPojazd
    {
        void IPojazd.Uruchom()
        {
            Console.WriteLine("silnik start");
        }

        void IPojazd.zatankuj()
        {
            Console.WriteLine("Zalej benzyną/ON/LPG");
        }

        void IPojazd.Zatrzymaj()
        {
            Console.WriteLine("silnik stop");
        }
    }
}
