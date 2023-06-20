using System;

namespace ConsoleApp2
{
    class Program
    {
        static char[,] quadrat;
        static int punkte;
        static int playerZeile;
        static int playerSpalte;

        static void Main(string[] args)
        {
            Start();

            while (true)
            {
                ConsoleKeyInfo keyInfo = Console.ReadKey(true);

                if (keyInfo.Key == ConsoleKey.Escape)
                    break;

                if (keyInfo.Key == ConsoleKey.UpArrow)
                    Bewegung(-1, 0);
                else if (keyInfo.Key == ConsoleKey.DownArrow)
                    Bewegung(1, 0);
                else if (keyInfo.Key == ConsoleKey.LeftArrow)
                    Bewegung(0, -1);
                else if (keyInfo.Key == ConsoleKey.RightArrow)
                    Bewegung(0, 1);
            }

            Console.WriteLine("Game ist beenden, punkte: " + punkte);
            Console.ReadLine(); 
        }

        static void Start()
        {
            quadrat = new char[20, 10];
            punkte = 0;

            Random rnd = new Random();

            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    char karakter = (rnd.Next(2) == 0) ? 'x' : ' ';
                    quadrat[i, j] = karakter;
                }
            }

            playerZeile = rnd.Next(20);
            playerSpalte = rnd.Next(10);
            quadrat[playerZeile, playerSpalte] = 'O';

            
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(quadrat[i, j] + " ");
                }
                Console.WriteLine();
            }
        }

        static void Bewegung(int zeile, int spalte)
        {
            int neueZeile = playerZeile + zeile;
            int neueSpalte = playerSpalte + spalte;

            if (neueZeile >= 0 && neueZeile < 20 && neueSpalte >= 0 && neueSpalte < 10 && quadrat[neueZeile, neueSpalte] == ' ')
            {
                quadrat[playerZeile, playerSpalte] = 'O';
                Console.SetCursorPosition(playerSpalte * 2, playerZeile);
                Console.Write(quadrat[playerZeile, playerSpalte]);

                playerZeile = neueZeile;
                playerSpalte = neueSpalte;

                quadrat[playerZeile, playerSpalte] = ' ';

                punkte++;

                Console.SetCursorPosition(playerSpalte * 2, playerZeile);
                Console.Write(quadrat[playerZeile, playerSpalte]);
             
                Console.SetCursorPosition(0, 21);
                Console.WriteLine("Punkte : " + punkte);

               
                if (!BleibteFeld())
                {
                    Console.WriteLine("Game ist beenden, punkte: " + punkte);
                    Console.ReadLine();
                    Environment.Exit(0);
                }
            }
        }

        static bool BleibteFeld()
        {
            for (int i = 0; i < 20; i++)
            {
                for (int j = 0; j < 10; j++)
                {
                    if (quadrat[i, j] == ' ')
                        return true;
                }
            }
            return false;
        }
    }
}
