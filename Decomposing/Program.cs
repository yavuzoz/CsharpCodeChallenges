using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*
 your challenges : write a c# function that breaks down a url into its component paths and 
print them out to the console
Criteria
-remove the "www." at the beginning of each URL
-Replace any "-" characters withs a blank space
-Split the URL at each "/" character 
*/
namespace Decomposing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string exampleURL = "www.docs.microsoft.com/dotnet/csharp/whats-new/csharp";
            Console.WriteLine($"Hit ENTER to break down the URL into its component ");
            Console.ReadLine();

            var components = BreakdownURL(exampleURL);

            for (int i = 0;i < components.Length; i++)
            {
                var indent = new string(' ', i * 2);
                Console.WriteLine($"{indent} -> {components[i]}");
                Console.ReadLine() ;
            }
        }

        public static string[] BreakdownURL(string urlString)
        {
            string noWWW = urlString.Remove(0, 4);

            string noDashes = noWWW.Replace("-", " ");

            string[] components = noDashes.Split('/');

            //string[] components2 = urlString.Remove(0, 4).Replace("-", " ").Split('/');

            return components;
        }
    }
}
