using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Program
{
    static void Main(string[] args)
    {
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(MyMethod(i));
            i++;
        }
        Console.ReadLine();
    }

    static int MyMethod(int i)
    {
        for (int j = 0; j < 5; j++)
        {
            Console.WriteLine(j);
        }
        return i; // i değeri geri döndürülüyor
    }
}