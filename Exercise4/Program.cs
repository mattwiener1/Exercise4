using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Exercise4
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            //4- Write a program that picks a random number between 1 and 10.
            //Give the user 4 chances to guess the number.
            //If the user guesses the number, display “You won"; otherwise, display “You lost".
            //(To make sure the program is behaving correctly, you can display the secret number on the console first.)

            var number = new Random().Next(1, 10);
            Console.WriteLine(number);
            Console.WriteLine("Please guess a number between 1 and 10: ");

            for (var i = 1; i <= 4; i++)
            {
                var guess = Convert.ToInt32(Console.ReadLine());
                if (guess == number)
                {
                    Console.WriteLine("Congrats!! You guessed the right number!");
                    break;
                }

                if (i == 4)
                {
                    Console.WriteLine("Sorry that was your last chance to guess correctly.");
                }

                else
                {
                    Console.WriteLine("That was not correct, please try again: ");
                }
            }
        }
    }
}
