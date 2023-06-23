using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace random_array_summen
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int[] zahlen = new int[10];

            int geradeSumm = 0 ;
            int ungeradeSumm=0 ;
            int summ=0;

            for(int i=0;i< zahlen.Length; i++)
            {
                zahlen[i] = random.Next(0, 11);

                if (zahlen[i] %2 == 0)
                {  
                    geradeSumm += zahlen[i];
                }
                else
                {
                    ungeradeSumm += zahlen[i];
                }
                summ = geradeSumm + ungeradeSumm;


            }
            Console.WriteLine($"total array geradeSumm is : {geradeSumm}");
            Console.WriteLine($"total array ungeradeSumm is : {ungeradeSumm}");
            Console.WriteLine($"total array Summ is : {summ}");
            Console.ReadLine();
        }
    }
}
