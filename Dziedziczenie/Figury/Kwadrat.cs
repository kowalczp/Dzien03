using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Figury
{
    public class Kwadrat : Prostokat
    {
        public Kwadrat(double bok) : base(bok, bok)
        {
            Console.WriteLine("Konstruktor klasy kwadrat");
        }

        public bool CzyKwadrat()
        {
            return base.CzyKwadrat();
        }
 
    }
}
