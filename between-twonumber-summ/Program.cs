using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace between_twonumber_summ
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("geben sie ein zahl ein : ");
            int zahl1 = int.Parse(Console.ReadLine());

            Console.WriteLine("geben sie ein zahl2 ein : ");
            int zahl2 = int.Parse(Console.ReadLine());
            int result = 0; 
            if(zahl1> zahl2)
            {
                while(zahl2 <= zahl1)
                {
                    result+=zahl2;
                    zahl2++;
                }
                Console.WriteLine(result);
           
            }else if(zahl2> zahl1)
            {
                while (zahl1 <= zahl2)
                {
                    result += zahl1;
                    zahl1++;
                }
                Console.WriteLine(result);
              
            }
            else
            {
                result = 0;
                Console.WriteLine(result);
            }
            Console.ReadLine();
        }
    }
}
