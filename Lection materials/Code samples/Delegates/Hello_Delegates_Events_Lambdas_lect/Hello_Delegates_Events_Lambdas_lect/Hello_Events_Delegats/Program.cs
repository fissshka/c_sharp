﻿using System;

namespace Hello_Events_lect
{
    class Program
    {
        // Subcriber to the Birds events
        static void Main( string[] args )
        {

            // Events
            MyCustomPublisher publisher = new MyCustomPublisher();
            MyCustomSubscriber sub1 = new MyCustomSubscriber(1, publisher);
            MyCustomSubscriber sub2 = new MyCustomSubscriber(2, publisher);
            MyCustomSubscriber sub3 = new MyCustomSubscriber(3, publisher);
            MyCustomSubscriber sub4 = new MyCustomSubscriber(4, publisher);

            sub1.Subscribe();
            sub2.Subscribe();
            sub3.Subscribe();
            sub4.Subscribe();

            publisher.StartCoolStuff();

            sub2.Unsubscribe();
            sub4.Unsubscribe();

            publisher.StartCoolStuff();

            sub1.Unsubscribe();
            sub3.Unsubscribe();

            publisher.StartCoolStuff();

            //Delegates
            publisher.PerformMultipleOperations(10, 10);


            Console.WriteLine("Observation bird flight");
            int ii;
            char rdk;
            try
            {
                do
                {
                    try
                    {
                        Console.WriteLine(@"Please, type the number
                1. subcribe titmouse
                2. subscibe/unsubscribe titmouse
                3. subcribe eagle
                                    ");
                        uint i = uint.Parse(Console.ReadLine());
                        switch (i)
                        {
                            case 1:
                                Console.WriteLine("Titmouse");
                                Bird My_Bird = new Bird("Titmouse", 15, 5, 2);
                                //Event handlers, subcribe
                                My_Bird.Startle += My_Bird_Startle;
                                My_Bird.NotSeeing += My_Bird_NotSeeing;
                             
                                    for (ii = 5; ii <= My_Bird.FlySpeed; ii++)
                                    {
                                        My_Bird.FlyAway(1);
                                    } 
                                break;
                            case 2:
                                Console.WriteLine("Titmouse");
                                Bird My_Bird1 = new Bird("Titmouse", 15, 5, 2);
                                //Event handlers, subcribe
                                My_Bird1.Startle += My_Bird_Startle;
                                My_Bird1.NotSeeing += My_Bird_NotSeeing;

                                //Unsusribe
                                    Console.WriteLine("Unsubcribe");
                                    My_Bird1.NotSeeing -= My_Bird_NotSeeing;
                                    for (ii = 5; ii <= My_Bird1.FlySpeed; ii++)
                                    {
                                        My_Bird1.FlyAway(1);
                                    }
                                break;
                            case 3:
                                Console.WriteLine("Eagle");
                                Bird My_Bird3 = new Bird("Eagle", 320, 20, 10);
                                //Event handlers, subcribe
                                My_Bird3.Startle += My_Bird_Startle;
                                My_Bird3.NotSeeing += My_Bird_NotSeeing;

                                for (ii = 20; ii <= 35; ii++)
                                {
                                    My_Bird3.FlyAway(ii);

                                }


                                break;
                            default:
                                break;
                        }
                    }
                    catch (BirdFlewAwayException ev)
                    {
                        Console.WriteLine(ev.Message);
                    }
                    catch (System.Exception e)
                    {
                        Console.WriteLine("CLS exception: Message -  " + e.Message + " Source - " + e.Source);
                       
                    }
                    finally
                    {
                        Console.WriteLine("For the next step ...");
                    }
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("Press Spacebar to exit; press any key to continue");
                    Console.ForegroundColor = ConsoleColor.White;
                    
                    
                    rdk = Console.ReadKey().KeyChar;
                } while (rdk != ' ');

            }
            catch (Exception mn)
            {
                
            }
        }

        static void My_Bird_NotSeeing(object sender, Birds_EventArgs e)
        {
            Console.WriteLine("End ... " + e.TimeReached);
            BirdFlewAwayException ex =
                        new BirdFlewAwayException("Bird flew with incredible speed!",
                                               "Invisible...", DateTime.Now);
            ex.HelpLink = "http://www.example.com";
            throw ex;

        }

        static void My_Bird_Startle(object sender, BirdEventsArgs e)
        {
           // throw new NotImplementedException();
            Console.WriteLine("Oh ... " + e.mess);
        }
    }
}
