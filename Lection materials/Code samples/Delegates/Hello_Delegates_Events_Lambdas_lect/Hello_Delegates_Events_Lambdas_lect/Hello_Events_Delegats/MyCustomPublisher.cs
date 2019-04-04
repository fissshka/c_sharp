using System;

namespace Hello_Events_lect
{
    public delegate void MyCustomEvent(object sener, MyCustomEventArgs eventArgs);

    public delegate int ArithmeticDelegate(int a, int b);

    public class MyCustomPublisher
    {
        public event MyCustomEvent CoolEvent;

        public void StartCoolStuff()
        {
            if (CoolEvent != null)
            {
                CoolEvent(this, new MyCustomEventArgs {DateTime = DateTime.Now});
            }
        }

        public void PerformMultipleOperations(int a, int b)
        {
            Console.WriteLine("Result of plus: " + this.PerformOperation(a, b, this.Plus));
            Console.WriteLine("Result of minus: " + this.PerformOperation(a, b, this.Minus));
            Console.WriteLine("Result of power: " + this.PerformOperation(a, b, this.Power));
        }

        private int PerformOperation(int a, int b, ArithmeticDelegate handler)
        {
            return handler(a, b);
        }

        private int Plus(int a, int b)
        {
            return a + b;
        }

        private int Minus(int a, int b)
        {
            return a - b;
        }

        private int Power(int a, int b)
        {
            return a * b;
        }
    }
}
