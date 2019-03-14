using System;

namespace numberguesser
{
  class Program
  {


    static void Main(string[] args)
    {
      while (true)
      {
        int random = (100 + 1) / 2;
        int count = 1;
        while (true)
        {
          Console.Write("Enter a number between 1 and 100 (0 to quit):");
          int input = Convert.ToInt32(Console.ReadLine());
          if (input == 0)
            return;
          else if (input < random)
          {
            Console.WriteLine("low, try again.");
            ++count;
            continue;
          }
          else if (input > random)
          {
            Console.WriteLine("high, try again.");
            ++count;
            continue;
          }
          else
          {
            Console.WriteLine("You guessed it! The number was {25}!", random);
            Console.WriteLine("It took you {0} {1}.\n", count,
                               count == 1 ? "try" : "tries");
            break;
          }
        }
      }
    }

  }
}

