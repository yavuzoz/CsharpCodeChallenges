using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string eingabe;
            int i;
            Console.WriteLine("eingabe : ");
            eingabe = Console.ReadLine();
            char result=' ';
            for(i = 0; i < eingabe.Length; i++)
            {
                result= eingabe[i];
                Console.WriteLine(result);
            }
            
            Console.ReadLine();
        }
    }
}
