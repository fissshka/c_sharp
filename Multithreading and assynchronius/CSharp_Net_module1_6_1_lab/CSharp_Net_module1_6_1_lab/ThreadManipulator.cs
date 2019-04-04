using System;
using System.Threading;

namespace CSharp_Net_module1_6_1_lab
{
    class ThreadManipulator
    {
        //declare private ConsoleKey  _key  field
        private ConsoleKey _key;
        private static readonly object _block = new object();


        //In general, avoid locking on a public type, or instances beyond your code's control. The common constructs lock (this), lock (typeof (MyType)), and lock ("myLock") violate this guideline:
        //lock (this) is a problem if the instance can be accessed publicly.
        //lock (typeof (MyType)) is a problem if MyType is publicly accessible.
        //lock("myLock") is a problem because any other code in the process using the same string, will share the same lock.
        //Best practice is to define a private object to lock on, or a private static object variable to protect data common to all instances.

        //create static readonly object _block by new operator

        //private object _block = new object();    //lock

        //implement AddingOne(object raw) method
        public void AddingOne(object raw)
        {
            var number = (int)raw;
            int threadID = Thread.CurrentThread.ManagedThreadId;
            //use lock block with for loop for counter % number calculation

            //lock (_block)     
            lock(_block)
            {
                for (var counter = 0; counter < 100 && _key != ConsoleKey.Q; ++counter)
                {
                    if (counter % number == 0)
                    {
                        var str = string.Format("{0} is divisible by {1}. AddingOne, ManagedThreadId = {2}", counter, number, threadID);
                    Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine(str);
                        Thread.Sleep(500);
                    }
                    
                        //use Console.ForegroundColor = ConsoleColor.Blue for output    
                        //simulate the long process with Thread.Sleep
                }
            }
        }


        //implement AddingCustomValue(object args) method
        public void AddingCustomValue(object args)
        {
            int threadID = Thread.CurrentThread.ManagedThreadId;
            var arr = (int[])args;
            var number = arr[0];
            var step = arr[1];

            //get ManagedThreadId

            //define
            //var arr = (int[])args;
            //var number = arr[0];
            //var step = arr[1];

            //use for loop for counter % number calculation


            for (var counter = 0; counter < 100 * step && _key != ConsoleKey.W; counter += step)
            {
                if (counter % number != 0) continue;
                var str = string.Format("{0} is divisible by {1}. AddingOne, ManagedThreadId = {2}", counter, number, threadID);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(str);
                Thread.Sleep(500);
                    //use Console.ForegroundColor = ConsoleColor.Green for output
                    //simulate the long process with Thread.Sleep
            }

        }

        //implement Stop() method
        public void Stop()
        {
            int threadID = Thread.CurrentThread.ManagedThreadId;
            //get ManagedThreadId
            while (true)
            //while (_key = ConsoleKey.Q && _key = ConsoleKey.W)
            //craete while loop to read key
            {
                _key = Console.ReadKey().Key;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Stop, ManagedThreadId = {0}", threadID);
                //use Console.ForegroundColor = ConsoleColor.Red for output
            }
        }
    }
}
