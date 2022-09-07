using System;

namespace GuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            // A random number guessing game
            Random random = new Random();
            int correctGuess = random.Next(1, 51);
            int guess = 0;
            int guessLimit = 5;
            bool gameOver = false;

            Console.WriteLine("I  am thinking of a number between 1 and 50, what is it?");

            while (gameOver != true)
            {
                Console.WriteLine("please enter your guess");
                guess = Convert.ToInt32(Console.ReadLine());
                guessLimit--;

                if (guess != correctGuess && guessLimit == 0)
                {
                    Console.WriteLine("guesses exceeded, you lose!");
                    gameOver = true;
                }
                else if (guess == correctGuess)
                {
                    Console.WriteLine("you got it right!");
                    gameOver = true;
                }
                else if (guess < correctGuess)
                {
                    Console.WriteLine("Oops, my number is greater than this, try again");
                }
                else if (guess > correctGuess)
                {
                    Console.WriteLine("Oops, my number is lesser than this, try again");
                }

            }
            Console.ReadLine();

        }
    }
}
