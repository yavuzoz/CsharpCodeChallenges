using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmailValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Give your email address: ");
            string input = Console.ReadLine();

            bool isValid = ValidateEmail(input);
            if (isValid)
            {
                Console.WriteLine("\nEmail is valid!");
            }
            Console.ReadLine();
        }

        public static bool ValidateEmail(string email)
        {
            char first = email[0];
            string atSymbol = "@";
            string dotCom = ".com";
            string dotCh = ".ch";

            if (Char.IsNumber(first) || Char.IsSymbol(first))
            {
                Console.WriteLine("\nSorry, emails can't start with numbers or symbols!");
                return false;
            }
            if (!email.Contains(atSymbol))
            {
                Console.WriteLine("\nYou have to include an '@' character...");
                return false;
            }
            if (!(email.EndsWith(dotCom) || email.EndsWith(dotCh)))
            {
                Console.WriteLine("\nGotta have a '.com' or '.ch' at the end...");
                return false;
            }

            return true;
        }
    }
}
