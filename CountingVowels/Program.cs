using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountingVowels
{
    internal class Program
    {
        private static Dictionary<char, int> vowelScores = new Dictionary<char, int>()
        {
            {'a', 1},
            {'e', 2},
            {'i', 3},
            {'o', 4},
            {'u', 5},
            {'y', 9},
            {'A', 1},
            {'E', 2},
            {'I', 3},
            {'O', 4},
            {'U', 5},
            {'Y', 9}
            // İstediğiniz diğer sesli harfleri ve puanlarını buraya ekleyebilirsiniz.
        };
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a text:");
            string input = Console.ReadLine();

            Console.WriteLine($"Score: {VowelCount(input)}");
            Console.ReadLine();
        }

        public static int VowelCount(string text)
        {
            int totalScore = 0;

            for(int i=0; i<text.Length; i++)
            {
                int points = 0;
                if (vowelScores.TryGetValue(text[i], out points))
                {
                    totalScore += points;
                }
            }
            return totalScore;
        }
    }
}
