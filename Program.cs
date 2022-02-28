using System;
using System.Collections.Generic;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Guess the secret number... uwu?");
          int x = int.Parse(Console.ReadLine());
           Console.WriteLine($"your guess is {x}");
           int secretNumber = 42;
           Console.Clear();
        }
    }
}
