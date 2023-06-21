using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace MehrZeichenDrucken
{
    class Program
    {
        static void Main(string[] args)
        {
            string text, result;
            int zahl;

            Console.WriteLine("Geben Sie ein Zeichen ein : ");
            text= Console.ReadLine();
            Console.WriteLine("Geben Sie ein Zahl ein : ");
            zahl=int.Parse(Console.ReadLine());

            result=zeichenDrucken(zahl, text);
            Console.WriteLine(result);
            Console.ReadLine();

        }

        public static string zeichenDrucken(int zahl, string text)
        {

            string result = "";
            int i = 0;

            do
            {
                result += text;
                i++;
                
            } while (i < zahl);

            return result;
        }
    }
}
