using Dziedziczenie.Figury;
using Dziedziczenie.KlasaAbstrakcyjna;
using Dziedziczenie.Przeciazanie;
using Dziedziczenie.Samochody;
using Dziedziczenie.Static;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dziedziczenie
{
    class Program
    {
        static void Main(string[] args)
        {
            Prostokat prostokat = new Prostokat(2.5, 3);
            double pole = prostokat.ObliczPole();
            Console.WriteLine("pole prostokata to {0}", pole);
            Kwadrat kwadrat = new Kwadrat(5);
            pole = kwadrat.ObliczPole();
            Console.WriteLine("Pole kwadratu to {0}",pole);
            Console.WriteLine("Czy kwadrat {0}", kwadrat.CzyKwadrat());


            Trojkat trojkat = new Trojkat(10, 3);
            pole = trojkat.ObliczPole();
            double obwod = trojkat.ObliczObwod();
            Console.WriteLine("Pole trojkata to {0} a obwod {1}", pole, obwod);


            int localMax = Utils.GetMaxValue(10, -1, 30, -20);
            Console.WriteLine("wartosc max {0}", localMax);

            Pojazd pojazd = new Pojazd();


            Product product = new Product("Chleb", 3.99);
            product.ShowInfo();
            product.ShowPrice();


            Wektor wektor1 = new Wektor(-1, 5);
            Wektor wektor2 = new Wektor(1, -5);

            Wektor _res = wektor1.Add(wektor2);
            _res.Print();

            _res = wektor1 + wektor2;
            _res.Print();

            _res = wektor1 + 3.5;
            _res.Print();

            Console.ReadKey();
        }
    }
}
