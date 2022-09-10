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
        static int Roll()
        {
            Random roll = new Random();
            return roll.Next(1,6);
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
                    int userRoll = Roll(), aiRoll = Roll();
                    Console.WriteLine("Twój rzut: " + userRoll+ " || Rzut komputera: " +aiRoll);
                    if(userRoll > aiRoll)
                    {
                        userWin++;
                        Console.WriteLine("Wygra³eœ ten rzut!");
                    }
                    else if (aiRoll > userRoll)
                    {
                        aiWin++;
                        Console.WriteLine("Komputer wygra³ ten rzut!");
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
                Console.WriteLine("Twoje punkty: " + userWin + " || Punkty komputera: " + aiWin+ "\n"); 
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

            Console.Write("Wpisz cokolwiek aby zakoñczyæ");
            Console.ReadLine();
        }
    }
}
