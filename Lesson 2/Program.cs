using System;

namespace Lesson_2
{
  class Program
  {
    static void Main(string[] args)
    {
      
      for (int potentialPrime = 2; potentialPrime < 100; potentialPrime++)
      {
        if (IsPrime(potentialPrime))
        {
          Console.Write(potentialPrime);
          Console.Write(", ");
        }

      }
    }

    private static bool IsPrime(int potentialPrime)
    {
        int maxDivisor = (int)Math.Sqrt(potentialPrime);
      for (int divisor = 2; divisor <= maxDivisor; divisor++)
      {
          if (potentialPrime % divisor == 0)
          {
           return false;   
          }
      }

          return true;
    }
  }
}
