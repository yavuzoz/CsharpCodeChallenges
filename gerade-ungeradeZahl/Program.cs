using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace gerade_ungeradeZahl
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geben sie ein zahl1 ein : ");
            int zahl1 = int.Parse(Console.ReadLine());

            Console.WriteLine("geben sie ein zahl2 ein : ");
            int zahl2 = int.Parse(Console.ReadLine());

            if (zahl1 > zahl2)
            {
                do
                {
                    if (zahl2 % 2 == 0)
                    {
                        Console.WriteLine(zahl2 + "gerade");
                    }
                    else
                    {
                        Console.WriteLine(zahl2 + " ungerade");
                    }
                    zahl2++;
                }while (zahl2<=zahl1);
            }
            if (zahl2 > zahl1)
            {
                do
                {
                    if (zahl1 % 2 == 0)
                    {
                        Console.WriteLine(zahl1 + "gerade");
                    }
                    else
                    {
                        Console.WriteLine(zahl1 + " ungerade");
                    }

                    zahl1++;
                } while (zahl1 <= zahl2);
            }
            Console.ReadLine();
        }
    }
}
