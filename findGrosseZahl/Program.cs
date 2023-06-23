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

            for(int i = 0; i < zahlen.Length; i++)
            {
                zahlen[i] = random.Next(0,11);
            }

            int maxNumber = zahlen[0];
            for (int i = 0;i < zahlen.Length; i++)
            {
                if (zahlen[i] > maxNumber)
                {
                    maxNumber = zahlen[i];
                }
            }
            Console.WriteLine("grosse zahl ist : " + maxNumber);
            Console.ReadLine();

        }
    }
}
