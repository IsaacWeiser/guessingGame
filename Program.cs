using System;
using System.Collections.Generic;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Guess the secret number... uwu?");
          int guess = int.Parse(Console.ReadLine());
           Console.WriteLine($"your guess is {guess}");
           int secretNumber = 42;
           Console.Clear();

           if (guess == secretNumber)
           {
               Console.WriteLine("congrats You Got It!");
           }
           else
           {
               Console.WriteLine("OOF... Try again :(");
           }
        }
    }
}
