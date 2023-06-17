using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 write a c# function that takes a list of scores and compute the lowest and highest values, 
as well as the sum and avarage of all the scores*/
namespace CalculatingSeasonStats
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> scores = new List<int>();

            for (int i = 1; i < 4; i++)
            {
                Console.WriteLine($"How many points did you score in game #{i}?");
                int input = int.Parse( Console.ReadLine() );    
                scores.Add( input );
            }
            PrintStats( scores );
            Console.ReadLine();

        }

        public static void PrintStats (List<int> scores)
        {
            scores.Sort();

            int lowest = scores[0];
            Console.WriteLine($"\nLowest scoring game \t -> {lowest}");

            int highest = scores[scores.Count - 1];
            Console.WriteLine($"\nHighest scoring game \t -> {highest}");

            int sum = 0;
            foreach ( int i in scores)
            {
                sum += i;
            }
            Console.WriteLine($"Total points game \t -> {sum}");

            Console.WriteLine($"Avarage points/ game \t -> {sum / scores.Count}");
        }
    }
}
