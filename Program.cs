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
            int totalGuesses;

          Console.WriteLine("What difficulty would you like: \n1=easy(8 trys), \n2=medium(6 trys), \n3=hard(4 trys)");  
          int diff = int.Parse(Console.ReadLine());

          if (diff == 1)
          {
              totalGuesses =8;
          }
          else if (diff == 2)
          {
              totalGuesses=6;
          }
          else
          {
              totalGuesses=4;
          }

         
          while (guessCounter < totalGuesses + 1)
          {

          Console.WriteLine("Guess the secret number... uwu?");
          Console.WriteLine($"This is guess #{guessCounter}");
          Console.WriteLine($"You have {totalGuesses-(guessCounter-1)} guesses left");
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
