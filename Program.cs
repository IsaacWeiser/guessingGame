using System;
using System.Collections.Generic;

namespace guessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            int secretNumber = new Random().Next(100);
            
          int guessCounter =1;
          while (guessCounter < 5)
          {

          Console.WriteLine("Guess the secret number... uwu?");
          Console.WriteLine($"This is guess #{guessCounter}");
          Console.WriteLine($"You have {4-(guessCounter-1)} guesses left");
          int guess = int.Parse(Console.ReadLine());
           
           
          
           
          

           if (guess == secretNumber)
           {
               Console.WriteLine("congrats You Got It!");
               guessCounter =5;
           }
           else
           {
               string hiorlo;
               if (guess > secretNumber)
               {
                   hiorlo = "too high";
               }
               else
               {
                   hiorlo = "too low";
               }
               Console.WriteLine($"OOF... your guess was {hiorlo}. Try again :(");
               guessCounter++;
           }
          }
        }
    }
}
