using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Ich bin ein Kommentar und stehe hier nur, weil der Ersteller dieses Programms, mit Befehlen herumspielen will.//
            /* Alles in mir ist auch ein Kommentar */
            
            double brutto = 0;
            double maerchensteuer_satz = 0.19;
            double netto = 0;
            double maerchensteuer = 0;

            Console.WriteLine("Wenn Sie ein Thermometer kaufen, wie viel darf das kosten? \nBitte als ganz Zahl eingeben.");
            brutto = double.Parse(Console.ReadLine());
            
            netto = brutto / (1 + maerchensteuer_satz);
            maerchensteuer = brutto - netto;

            Console.Write("Bei {0:N2}", brutto);
            Console.Write(" Euronen Kosten und einem Märchensteuersatz \nvon {0:p}", maerchensteuer_satz);
            Console.Write(", kostet es nur {0:N2} Euronen", netto);
            Console.Write(" an sich \nund man muss {0:N2} Euronen", maerchensteuer);
            Console.Write(" an den gierigen Staat abtreten.");

            double celsius, fahrenheit, kelvin;

            Console.WriteLine("\n \n \nGeben Sie bitte eine beliebige Temperatur ein.");

            celsius = double.Parse(Console.ReadLine());
            fahrenheit = ((celsius * 9) / 5) + 32;
            kelvin = celsius + 273.15;

            Console.Write("Eine Temperatur von {0:F0}", celsius);
            Console.Write(" °C, geben die Ammis lieber als {0:F0}", fahrenheit);
            Console.Write(" °F, und \nWissenschaftler lieber als {0:F0}", kelvin);
            Console.Write(" °K aus.");
            Console.ReadKey();

        }
    }
}
