using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hello_Operators_advstud
{
    class Program
    {
        static void Main(string[] args)
        {
            const int MyMax = 200;

            Random random = new Random();
            // random.Next(MaxValue) returns a 32-bit signed integer that is greater than or equal to 0 and less than MaxValue

            // implement input of number and comparison result message in the while circle with  comparison condition
            Console.WriteLine("Please, enter your guess:");
            int Guess_number = random.Next(MyMax) + 1;
            int input_value = int.Parse(Console.ReadLine());
            while (true)
            {
                if (input_value > Guess_number)
                {
                    Console.WriteLine("Guessed number is " + Guess_number + " Your entered value is too high!");
                }
                else if (input_value < Guess_number)
                {
                    Console.WriteLine("Guessed number is " + Guess_number + " Your entered value is too low!");
                }
                else Console.WriteLine("Guessed number is " + Guess_number + " You've guessed. Congarts ;)");
                break;
            }

            Console.WriteLine("Exit");
        }   
    }
}
