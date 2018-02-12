using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class_construct_etc
{
    class Program
    {
        static void Main(string[] args)
        {
            First_class f1 = new First_class();
            First_class f2 = new First_class("Hello world");

            f1.write_hello();
            f1.write_hello();

            f1.write_property();
            f2.write_property();

            f1.SetFieldValue("Hello fields");
            f1.write_hello();

            int a;
                try
            {
                do
                {
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.WriteLine("Please, fill in the number")
                }
            }
        }
    }
}
