using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace reverseName
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("bitte Namen eingeben : ");
            string name = Console.ReadLine();
          
            
            string reversedName = reverseName(name);
            Console.WriteLine(reversedName);
            Console.ReadLine();
        }

        public static string reverseName(string name)
        {
            string rename="";
            for(int i=name.Length-1; i>=0; i--)
            {
                rename += name[i]; 
              
            }
            return rename;
        }

    }
}
