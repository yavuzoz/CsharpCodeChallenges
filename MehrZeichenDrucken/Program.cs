using System;

class Program
{
    static void Main(string[] args)
    {
        string result ;
        string zeichen ;
        int zahl ;
        Console.WriteLine("geben sie ein zeichen ein : ");
        zeichen = Console.ReadLine();
        Console.WriteLine("geben sie ein zahl ein : ");
        zahl= int.Parse(Console.ReadLine());

        result = zeichenDrucken(zahl, zeichen);
        Console.WriteLine(result);
        Console.ReadLine();
    }

    public static string zeichenDrucken(int zahl, string zeichen)
    {
        string resultat = "";
        do
        {
            resultat += zeichen;
            zahl--;
        } while (zahl > 0);
         return resultat;
    }
}
