using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MethodsParameters
{
    class MyClass2
    {
        public MyClass2() : this(10, 10)
        {
            Console.WriteLine("Hello from empty ctor");
        }

        public MyClass2(int a) : this(a, 10)
        {
            Console.WriteLine("Hello from 1 param ctor");
        }

        public MyClass2(int a, int b)
        {
            int c = a * b;
            Console.WriteLine(c);
        }

        public void Method() { }                     // Method()
        public void Method(int x) { }              // Method(int)
        public void Method(ref int x) { }   // Method(ref int)  error
        public void Method(int x, int y) { } // Method(int, int)
        public int Method(string s) { return 0; } // Method(string)
        // public int Method(int x) { return 0; } // Method(int) error
        // public void Method(string[] a) { }     // Method(string[])
        public void Method(params string[] a) { } // Method(string[])      error
    }

}
