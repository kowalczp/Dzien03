﻿using System;
using Dziedziczenie.Samochody;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie.Pojazdy
{
    class SamochodElektryczny : Samochod
    {
        protected double pojemnoscBaterii;

        public void Zatankuj()
        {
            Console.WriteLine("podlacz d pradu");
        }
    }
}