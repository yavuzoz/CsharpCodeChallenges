using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findGrosseZahl
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();

            int[] zahlen = new int[10];
            int maxNumber = zahlen[0];
            int minNumber = 11;

            for (int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = random.Next(0,11);
 
                if (zahlen[i] > maxNumber)
                {
                    maxNumber = zahlen[i];
                }
                else if(zahlen[i] < minNumber)
                {
                   minNumber= zahlen[i] ;
                }
            }
            Console.WriteLine("grosse zahl ist : " + maxNumber);
            Console.WriteLine("kleiner zahl ist : " + minNumber);
            
            Console.ReadLine();

        }
    }
}
