using System;
using System.Threading;

namespace CSharp_Net_module1_6_1_lab
{
    class Program
    {
        static void Main(string[] args)
        {
            //use Console.ForegroundColor = ConsoleColor.Gray for output
            var manipulator = new ThreadManipulator();
            //create ThreadManipulator object
            var ThreadOne = new Thread(manipulator.AddingOne);
            var ThreadTwo = new Thread(manipulator.AddingOne); 
            var CustThread = new Thread(manipulator.AddingCustomValue);
            var StopThread = new Thread(manipulator.Stop)
            {
                IsBackground = true
            };

        //create first thread for AddingOne method
        //create second thread for AddingOne method

        //create thread for AddingCustomValue method

        //create Background thread for Stop method
        StopThread.Start();
            ThreadOne.Start(10);
            ThreadTwo.Start(20);
            CustThread.Start(new[] { 5, 15 });
            ThreadOne.Join();
            ThreadTwo.Join();
            CustThread.Join();
        //start Background thread for Stop method

            //start first thread for AddingOne method with argument = 10
            //start second thread for AddingOne method with argument = 20

            //start thread for AddingCustomValue method with argument new[] { 5, 15 }

            //join threads

            Console.ReadKey();
            
        }
    }
}
