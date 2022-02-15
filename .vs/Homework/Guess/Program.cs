using System;

namespace Guess
{
    class Program
    {
        static void Main(string[] args)
        {
            // guess the number
            Random random = new Random();
            int min = 1;
            int max = 100;
            int guess;
            int gesses;
            bool playAgain = true;

            while (playAgain)
            {
                guess = 0;
                gesses = 0;
                int number = random.Next(min, max + 1);


                while (guess != number)
                {
                    Console.WriteLine("Guess number between " + min + " - " + max + " :");
                    guess = Convert.ToInt32(Console.ReadLine());

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " - guess is to high!");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " - guess is to low!");
                    }
                    gesses++;
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("You win");
                Console.WriteLine("Guesses :" + gesses);
                Console.WriteLine("\n Would you like to play again?\n Press 1 if yes, and any other key if no: ");
                string Choice = Console.ReadLine();
                if (Choice == "1")
                {
                    playAgain = true;
                }
                else
                {
                    playAgain = false;
                }
            }
        }
    }
}
