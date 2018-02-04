using System;
using System.Threading;

namespace Hello_Console_stud
{
    class Program
    {
        static void Main(string[] args)
        {
            int a;
            try
            {
                do
                {
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine(@"Please,  type the number:
                    1.  f(a,b) = |a-b| (unary)
                    2.  f(a) = a (binary)
                    3.  music
                    4.  morse sos
          
                    ");
                    try
                    {
                        a = (int)uint.Parse(Console.ReadLine());
                        switch (a)
                        {
                            case 1:
                                My_strings();
                                Console.WriteLine("");
                                break;
                            case 2:
                                My_Binary();
                                Console.WriteLine("");
                                break;
                            case 3:
                                My_music();
                                Console.WriteLine("");
                                break;
                            case 4:
                                Morse_code();
                                Console.WriteLine("");
                                break;                   
                            default:
                                Console.WriteLine("Exit");
                                break;
                        }

                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("Error"+e.Message);
                    }                   
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                while (Console.ReadKey().Key != ConsoleKey.Spacebar);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
        #region ToFromBinary
        static void My_Binary()
        {
            //Implement positive integer variable input
            Console.WriteLine("Please, enter positive number");
            int num = int.Parse(Console.ReadLine()); 
            //Present it like binary string
            //   For example, 4 as 100
            string binar_one = Convert.ToString(num, 2);
            Console.WriteLine("Your number in the binary representation is " + binar_one);
            //Use modulus operator to obtain the remainder  (n % 2) 
            //and divide variable by 2 in the loop
            //int number = Convert.ToInt32(binar_one)
            Console.WriteLine("Your excess after operation is  " + Convert.ToInt32(num) % 2);
            //Use the ToCharArray() method to transform string to chararray
            //and Array.Reverse() method
            char[] new_char = binar_one.ToCharArray();
            Console.WriteLine("Your char is " + new_char);
            Array.Reverse(new_char);
            Console.WriteLine("Your char is " + new_char);

            //Console.WriteLine("Exit");
            //Console.ReadLine();
        }
        #endregion

        #region ToFromUnary
        static void My_strings()
        {
            //Declare int and string variables for decimal and binary presentations
            int one, two;
            string input, firstbin, secondbin;

            //Implement two positive integer variables input
            Console.WriteLine("Please, enter yout first number");
            one = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter yout second number");
            two = int.Parse(Console.ReadLine());
            //To present each of them in the form of unary string use for loop
            firstbin = Convert.ToString(one, 2);
            secondbin = Convert.ToString(two, 2);

            //Use concatenation of these two strings 
            //Note it is necessary to use some symbol ( for example “#”) to separate
            string str1 = firstbin + '*'  + secondbin;
            //Check the numbers on the equality 0
            if (one != 0)
            {
                Console.WriteLine("First number is not equal to 0");
            }
            else if (two != 0)
            {
                Console.WriteLine("Second number is not equal to 0");
            }
            else
            {
                Console.WriteLine("None of numbers are equal to 0");
            }
            //Realize the  algorithm for replacing '1#1' to '#' by using the for loop
            Console.WriteLine("Please, type 1#1");
            Console.ReadLine();
            input = "1#1";
            char[] charredstring = input.ToCharArray();
            for(int i = 1; i < charredstring.Length-1; i++)
            {
                if (charredstring[i] == '#' && charredstring[i-1]=='1' && charredstring[i+1]=='1')
                {
                    charredstring[i - 1] = charredstring[i];
                    for (int j = i; j < charredstring.Length-2; j++)
                    {
                        charredstring[j] = charredstring[j + 2];
                    }

                }
            }
            Console.WriteLine(charredstring);
            //Delete the '#' from algorithm result
            for (int i = 0; i < charredstring.Length - 1; i++)
            {
                if (charredstring[i] == '#')
                {
                    for (int j = i; j < charredstring.Length - 1; j++)
                    {
                        charredstring[j] = charredstring[j + 1];
                    }
                }
            }
            Console.WriteLine(charredstring);
            //Output the result 
        }
        #endregion

        #region My_music
        static void My_music()
        {
            //HappyBirthday
            Thread.Sleep(2000);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(330, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(297, 500);
            Thread.Sleep(125);
            Console.Beep(264, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(250);
            Console.Beep(264, 125);
            Thread.Sleep(125);
            Console.Beep(2642, 500);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 250);
            Thread.Sleep(125);
            Console.Beep(352, 125);
            Thread.Sleep(125);
            Console.Beep(330, 500);
            Thread.Sleep(125);
            Console.Beep(297, 1000);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(250);
            Console.Beep(466, 125);
            Thread.Sleep(125);
            Console.Beep(440, 500);
            Thread.Sleep(125);
            Console.Beep(352, 500);
            Thread.Sleep(125);
            Console.Beep(396, 500);
            Thread.Sleep(125);
            Console.Beep(352, 1000);
        }
        #endregion

        #region Morse
        static void Morse_code()
        {   
            //Create string variable for 'sos'      

            //Use string array for Morse code
            string[,] Dictionary_arr = new string [,] { { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z", "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" },
            { ".-   ", "-... ", "-.-. ", "-..  ", ".    ", "..-. ", "--.  ", ".... ", "..   ", ".--- ", "-.-  ", ".-.. ", "--   ", "-.   ", "---  ", ".--. ", "--.- ", ".-.  ", "...  ", "-    ", "..-  ", "...- ", ".--  ", "-..- ", "-.-- ", "--.. ", "-----", ".----", "..---", "...--", "....-", ".....", "-....", "--...", "---..", "----." }};
            //Use ToCharArray() method for string to copy charecters to Unicode character array
            //Use foreach loop for character array in which
            Console.WriteLine("Please input your message");
            string input_message = Console.ReadLine();
            char[] input_in_chars = input_message.ToCharArray();
            string morze_str ="";
            foreach (char item in input_message)
            {
                for (int i = 0; i < 36; i++)
                {
                    if (Convert.ToChar(Dictionary_arr.GetValue(0, i)) == item)
                    {
                        morze_str += Dictionary_arr.GetValue(1, i);
                        break;
                    }
                }

            }
            Console.WriteLine(morze_str);
            //Implement Console.Beep(1000, 250) for '.'
            // and Console.Beep(1000, 750) for '-'
            //Use Thread.Sleep(50) to separate sounds
            //         
            char[] input_sound = morze_str.ToCharArray();
            foreach (char item in input_sound)
            {
                if (item == '.')
                {
                    Console.Beep(1000, 250);
                }
                else if (item == '-')
                {
                    Console.Beep(1000, 750);
                }
                Thread.Sleep(50);
            }

        }
        

                 
    }

        #endregion
        
    }

