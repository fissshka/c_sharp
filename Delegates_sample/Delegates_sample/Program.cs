using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates_sample
{
    class Program
    {
        static void Main(string[] args)
        {
            MyPublisher publisher = new MyPublisher();
            Subscribe subscribe = new Subscribe(1, publisher);
            Subscribe subscribe1 = new Subscribe(2, publisher);
            Subscribe subscribe2 = new Subscribe(3, publisher);
            //subscribe.Mypublisher = publisher;

            publisher.RaiseEvent();
            Console.WriteLine();

            subscribe2.UnSUb();
            publisher.RaiseEvent();

            Console.ReadLine();
        }
    }
}
