using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 this challenges goal is to write a c# function, that takes in a person's age and print out
how many times they voted for president. The function is going to take in an integer value  for the users age
and return the number of presidents they voted for as an integer value as well. */
using System;

namespace Voting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("How old are you? : ");
            int input = int.Parse(Console.ReadLine());

            int presidents = CalculatePresidents(input);
            Console.WriteLine($"You've voted for {presidents} presidents!");
            Console.ReadLine();
        }

        public static int CalculatePresidents(int age)
        {
            int eligibleYears = age - 18;
            int presidents = 0;

            if (eligibleYears <= 0)
            {
                Console.WriteLine("Looks like you're not old enough to vote yet.");
                return 0;
            }

            for (int i = 0; i < eligibleYears; i++)
            {
                if (i % 4 == 0)
                {
                    presidents++;
                }
            }

            return presidents;
        }
    }
}
