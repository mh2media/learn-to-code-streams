using System;

namespace learn_to_code_streams
{
    class Program
    {
        static void Main(string[] args)
        {
             Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Enter your name:");
            Console.ForegroundColor = ConsoleColor.White;
            string name = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine($"Hello {name}!");
            Console.WriteLine($"Hope you're having a great day. I like the name {name}.");
            Console.WriteLine($"So, {name}, what's your favorite number?");
            Console.ForegroundColor = ConsoleColor.White;
            string rawText = Console.ReadLine();
            int.TryParse(rawText, out int number);
            /*  
            Above line is same as: int unsafeInt = int.Parse(rawText)
            The code above is a way to make sure entering a string or number other than integer doesn't break the program at runtime. 
            */
            
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < number; i++)
            {
                Console.WriteLine($"You are awesome {name}");
            }

            Console.WriteLine("\n");
            Console.WriteLine($"You chose {number}.");
            int betterNumber = number +1;
            Console.WriteLine($"I like the number {betterNumber} better. It's larger.");
            Console.ForegroundColor = ConsoleColor.White;

        }
    }
}
