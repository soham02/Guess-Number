using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GuessNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int random_number = random.Next(1, 11);
            int guess;
            int guess_number = 3;
            bool gameOver = false;

            Console.WriteLine("Pick a number between 1 to 10");

            while (gameOver == false)
            {
                guess = Convert.ToInt32(Console.ReadLine());
                guess_number--;

                if(guess != random_number && guess_number == 0)
                {
                    Console.WriteLine("GAME OVER");
                    gameOver = true;
                }
                else if (guess == random_number)
                {
                    Console.WriteLine("WINNER");
                    gameOver = true;       
                }
                else if (guess > random_number)
                {
                    Console.WriteLine("Number is smaller than that.");
                }
                else if (guess < random_number)
                {
                    Console.WriteLine("Number is greater than that.");
                }
            }
            Console.ReadLine();
        }
    }
}
