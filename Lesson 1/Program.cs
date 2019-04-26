using System;

namespace learn_to_code_streams
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            // Use underscore to replace comma in numbers
            int number = rand.Next(1, 1_000);
            Console.WriteLine("I've chosen a number between 1 and 1,000. Can you guess it?");

            int guess;
                do
                {
                   Console.WriteLine("What's your guess?");
                string guessString = Console.ReadLine();
                int.TryParse(guessString, out guess);
                if (guess < number)
                {
                    Console.WriteLine("Too low, guess again.");
                }

                if (guess > number)
                {
                    Console.WriteLine("Too high, guess again.");
                }

                } while (guess != number);
           Console.WriteLine("You got it!");
        }
    }
}
