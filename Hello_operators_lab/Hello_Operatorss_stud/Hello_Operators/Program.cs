using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloOperators_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            long a;
            Console.WriteLine(@"Please,  type the number:
            1. Farmer, wolf, goat and cabbage puzzle
            2. Console calculator
            3. Factorial calculation
            ");

            a = long.Parse(Console.ReadLine());
            switch (a)
            {
                case 1:
                    Farmer_puzzle();
                    Console.WriteLine("");
                    break;
                case 2:
                    Calculator();
                    Console.WriteLine("");
                    break;
                case 3:
                    Factorial_calculation();
                    Console.WriteLine("");
                    break;
                default:
                    Console.WriteLine("Exit");
                    break;
            }
            Console.WriteLine("Exit");
        }
            #region farmer
            static void Farmer_puzzle()
            {
                //Key sequence: 3817283 or 3827183
                // Declare 7 int variables for the input numbers and other variables
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(@"From one bank to another should carry a wolf, goat and cabbage. 
At the same time can neither carry nor leave together on the banks of a wolf and a goat, 
a goat and cabbage. You can only carry a wolf with cabbage or as each passenger separately. 
You can do whatever how many flights. How to transport the wolf, goat and cabbage that all went well?");
                Console.WriteLine("There: farmer and wolf - 1");
                Console.WriteLine("There: farmer and cabbage - 2");
                Console.WriteLine("There: farmer and goat - 3");
                Console.WriteLine("There: farmer  - 4");
                Console.WriteLine("Back: farmer and wolf - 5");
                Console.WriteLine("Back: farmer and cabbage - 6");
                Console.WriteLine("Back: farmer and goat - 7");
                Console.WriteLine("Back: farmer  - 8");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("Please,  type numbers by step ");

                long input1;
                long input2;
                long input3;
                long input4;
                long input5;
                long input6;
                long input7;
                // Implement input and checking of the 7 numbers in the nested if-else blocks with the  Console.ForegroundColor changing
                input1 = long.Parse(Console.ReadLine());      
            if (input1 == 3)
                {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("Correct. Next step, please");
                input2 = long.Parse(Console.ReadLine());
                if (input2 == 8)
                    {
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Correct. Next step, please");
                    input3 = long.Parse(Console.ReadLine());
                    if (input3 == 2)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Correct. Next step, please");
                        input4 = long.Parse(Console.ReadLine());
                        if (input4 == 7)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Correct. Next step, please");
                            input5 = long.Parse(Console.ReadLine());
                            if (input5 == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Correct. Next step, please");
                                input6 = long.Parse(Console.ReadLine());
                                if (input6 == 8)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Correct. Next step, please");
                                    input7 = long.Parse(Console.ReadLine());
                                    if (input7 == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Excellent. You've done it :)");
                                        return;
                                    }
                                }
                                else Console.WriteLine("Exit");
                            }
                            else if (input5 == 2)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Correct. Next step, please");
                                input6 = long.Parse(Console.ReadLine());
                                if (input6 == 8)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Correct. Next step, please");
                                    input7 = long.Parse(Console.ReadLine());
                                    if (input7 == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Excellent. You've done it :)");
                                        return;
                                    }
                                }
                                else Console.WriteLine("Exit");
                            }

                            else Console.WriteLine("Exit");
                        }
                        else Console.WriteLine("Exit");
                    }
                        else if (input3 == 1)
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Correct. Next step, please");
                        input4 = long.Parse(Console.ReadLine());
                        if (input4 == 7)
                            {
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Correct. Next step, please");
                           input5 = long.Parse(Console.ReadLine());
                            if (input5 == 1)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("Correct. Next step, please");
                                input6 = long.Parse(Console.ReadLine());
                                if (input6 == 8)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Correct. Next step, please");
                                    input7 = long.Parse(Console.ReadLine());
                                    if (input7 == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Excellent. You've done it :)");
                                        return;
                                    }
                                }
                                else Console.WriteLine("Exit");
                            }
                                else if (input5 == 2)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("Correct. Next step, please");
                                input6 = long.Parse(Console.ReadLine());
                                if (input6 == 8)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Correct. Next step, please");
                                    input7 = long.Parse(Console.ReadLine());
                                    if (input7 == 3)
                                    {
                                        Console.ForegroundColor = ConsoleColor.Yellow;
                                        Console.WriteLine("Excellent. You've done it :)");
                                            return;
                                    }
                                }
                                    else Console.WriteLine("Exit");
                            }

                                else Console.WriteLine("Exit");
                        }
                            else Console.WriteLine("Exit");
                    }
                        else Console.WriteLine("Exit");

                }
                    else Console.WriteLine("Exit");
            }
                else Console.WriteLine("Exit");
            }

            #endregion

            #region calculator
            static void Calculator()
            {
                // Set Console.ForegroundColor  value
                Console.WriteLine(@"Select the arithmetic operation:
1. Multiplication 
2. Divide 
3. Addition 
4. Subtraction
5. Exponentiation ");
            // Implement option input (1,2,3,4,5)
            //     and input of  two or one numbers
            //  Perform calculations and output the result 
            
            long act;
            act = long.Parse(Console.ReadLine());
            switch(act)
            {
                case 1:
                    long val1;
                    long val2;
                    long res;
                    Console.WriteLine("Multiplication");
                    Console.WriteLine("Please, incert value 1");
                    val1 = long.Parse(Console.ReadLine());
                    Console.WriteLine("Please, incert value 2");
                    val2 = long.Parse(Console.ReadLine());
                    res = val1 * val2;
                    Console.WriteLine(res);
                    Console.ReadLine();
                break;

                case 2:
                    long valD1;
                    long valD2;
                    long resD;
                    Console.WriteLine("Divide");
                    Console.WriteLine("Please, incert value 1");
                    valD1 = long.Parse(Console.ReadLine());
                    Console.WriteLine("Please, incert value 2");
                    valD2 = long.Parse(Console.ReadLine());
                    resD = valD1 / valD2;
                    Console.WriteLine(resD);
                    Console.ReadLine();
                    break;
                case 3:
                    long valAD1;
                    long valAD2;
                    long resAD;
                    Console.WriteLine("Addition");
                    Console.WriteLine("Please, incert value 1");
                    valAD1 = long.Parse(Console.ReadLine());
                    Console.WriteLine("Please, incert value 2");
                    valAD2 = long.Parse(Console.ReadLine());
                    resAD = valAD1 + valAD2;
                    Console.WriteLine(resAD);
                    Console.ReadLine();
                    break;
                case 4:
                    long valS1;
                    long valS2;
                    long resS;
                    Console.WriteLine("Subtraction");
                    Console.WriteLine("Please, incert value 1");
                    valS1 = long.Parse(Console.ReadLine());
                    Console.WriteLine("Please, incert value 2");
                    valS2 = long.Parse(Console.ReadLine());
                    resS = valS1 - valS2;
                    Console.WriteLine(resS);
                    Console.ReadLine();
                    break;
                case 5:
                    long valE1;
                    long valE2;
                    long resE;
                    Console.WriteLine("Exponentiation");
                    Console.WriteLine("Please, incert value 1");
                    valE1 = long.Parse(Console.ReadLine());
                    Console.WriteLine("Please, incert value 2");
                    valE2 = long.Parse(Console.ReadLine());
                    //resE = valE1 ^ valE2;
                    Console.WriteLine("{0}^{1} = {2:N0} (0x{2:X})",
                           valE1, valE2, (long)Math.Pow(valE1, valE1));
                    Console.ReadLine();
                    break;
            }
        }
        #endregion

        #region Factorial
        static void Factorial_calculation()
        {
            // Implement input of the number
            Console.WriteLine("Enter value");
            int input = int.Parse(Console.ReadLine());
            int output = input;
            for (int i = 1; i < input; i++)
            {
                output = output * i;
                //int fin_res = output * output;
            }
            Console.WriteLine(output);
            // Implement input the for circle to calculate factorial of the number
            // Output the result
        }
            #endregion
        }
    }