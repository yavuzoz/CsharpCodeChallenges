using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool weiterGehen = false;

            do
            {
                int eingabe;
                Console.WriteLine("bitte zahl eingeben");
                eingabe = int.Parse(Console.ReadLine());
                if (unterprogram(eingabe))
                {
                    Console.WriteLine("schöne zahl ");
                }
                else { Console.WriteLine("kein schöne zahl "); }
                Console.ReadLine();

                Console.WriteLine("Möchten Sie weiter Zahl geben ? ( ja/nein)");
                string antwort= Console.ReadLine();
                if (antwort.ToLower() == "ja")
                {
                    weiterGehen=true;
                }
                

            }while (weiterGehen==true);
            Console.WriteLine("Programm beendet.");
            Console.ReadLine();


        }

        public static bool unterprogram(int x)
        {

                bool resultat;
                if (x % 2 == 0)
                {
                    resultat = true;
                }
                else
                {
                    resultat = false;

                }
     
                return resultat;
           
        }
    }
}
