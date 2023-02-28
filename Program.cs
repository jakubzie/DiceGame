using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ProgramNumeroUno
{

    class Program
    {
        //it doesn't work with function because function creates new Random instance each time. it creates it in the same moment
        //so it produces the same "random" number
        static int Roll(int min, int max)
        {
            Random roll = new Random();
            return roll.Next() * (max - min) + min;
        }

        static void Main(string[] args)
        {
            int userWin = 0, aiWin = 0;
            int i = 0;
            while (i < 5)
            {
                Console.Write("Wpisz cokolwiek aby rzuciæ kostk¹: ");
                if (Console.ReadLine() != "")
                {
                    Random roll = new Random();
                    int userRoll = roll.Next(1,6);
                    int aiRoll = roll.Next(1,6);
                    Console.WriteLine("\nTwój rzut: " + userRoll+ " || Rzut komputera: " +aiRoll);
                    if(userRoll > aiRoll)
                    {
                        userWin++;
                        Console.WriteLine("Wygra³eœ w tym rzucie!");
                    }
                    else if (aiRoll > userRoll)
                    {
                        aiWin++;
                        Console.WriteLine("Komputer wygra³ w tym rzucie!");
                    }
                    else
                    {
                        Console.WriteLine("Remis! Ka¿dy dostaje po punkcie.");
                        aiWin++;
                        userWin++;
                    }
                    i++;
                }
                else
                {
                    Console.WriteLine("Pole nie mo¿e byæ puste!!");
                }
                Console.WriteLine("Twoje punkty: " + userWin + " || Punkty komputera: " + aiWin+ "\n\n------\n"); 
            }
            if(userWin > aiWin)
            {
                Console.WriteLine("Wygra³eœ!\n");
            }
            else if(aiWin > userWin)
            {
                Console.WriteLine("Komputer wygra³ ;c\n");
            }
            else
            {
                Console.WriteLine("Remis!\n");
            }

            Console.Write("Wpisz cokolwiek aby zakoñczyæ: ");
            Console.ReadLine();
        }
    }
}
