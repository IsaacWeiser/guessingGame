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

          Console.WriteLine("What difficulty would you like: \n1=easy(8 trys), \n2=medium(6 trys), \n3=hard(4 trys), \n4=cheater(unlimited guesses)");  
          int diff = int.Parse(Console.ReadLine());

            int guessMod =0;

          if (diff == 1)
          {
              totalGuesses =8;
          }
          else if (diff == 2)
          {
              totalGuesses=6;
          }
          else if (diff == 3)
          {
              totalGuesses=4;
          }
          else
          {
              guessMod =1;
              totalGuesses = 999999;
          }

         
          while ((guessCounter - (guessCounter * guessMod))+ 1 < totalGuesses + 1)
          {

          Console.WriteLine("\nGuess the secret number... uwu?");
          Console.WriteLine($"This is guess #{guessCounter}");
          if (diff != 4)
          {
          Console.WriteLine($"You have {totalGuesses-(guessCounter-1)} guesses left");
          }
          else
          {
              Console.WriteLine($"You have unlimited guesses left");
          }
          int guess = int.Parse(Console.ReadLine());
           
           
          
           
          

           if (guess == secretNumber)
           {
               Console.WriteLine("\n\ncongrats You Got It!");
              totalGuesses=-1;
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
               Console.WriteLine($"\n\nOOF... your guess was {hiorlo}. Try again :(");
               guessCounter++;
           }
          }
        }
    }
}
