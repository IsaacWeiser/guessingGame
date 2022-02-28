using System;
using System.Collections.Generic;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            
          int guessCounter =1;
          while (guessCounter < 5)
          {

          Console.WriteLine("Guess the secret number... uwu?");
          Console.WriteLine($"This is guess #{guessCounter}");
          int guess = int.Parse(Console.ReadLine());
           
          int secretNumber = 42;
           

           if (guess == secretNumber)
           {
               Console.WriteLine("congrats You Got It!");
               guessCounter =5;
           }
           else
           {
               Console.WriteLine("OOF... Try again :(");
               guessCounter++;
           }
          }
        }
    }
}
