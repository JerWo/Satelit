using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// --------------------------------------------
// Datei:			M403_7742_Satelit
// Datum:			06.12.2018
// Ersteller:		Wildi Juri (Hypothekarbank Lenzburg AG)
// Version:		    1.0
// Änderungen:		-
// Beschreibung:    
//
// This program calculats the travel time for a satalite with a given travel height. 
// --------------------------------------------

namespace Satelliten_Aufgabe
{
    class Program
    {
        static void Main(string[] args)
        {
            //variables
            double Re = 6378137.0, g = 9.81, T = 0, x;

            //travel height input
            
            {
                Console.Write("Bitte geben Sie die Flughöhe in Kilometern an: ");
                string height = Console.ReadLine();

                try
                {
                    x = Convert.ToDouble(height);
                }

                catch (Exception)
                {
                    x = 0;
                }
            }
            while (x <= 0) ;

            T = 2 * Math.PI / Re * Math.Pow(Math.Pow(Re + x * 1000, 3) / g, 0.5) / 3600;

            //Output
            Console.WriteLine("Umlaufzeit in Stunden: " + T);
            Console.ReadKey();
        }
    }
}
