using System;
namespace MyDelegate
{
    public delegate void MyEvent(object sender, EventArgs eventArgs);
    public delegate int MyDelegate(int a, int b);

    public class MyPublisher
    {
        public event MyEvent Event;
        public int A { get; set; }
        public void RaiseEvent()
        {
            int a = this.Operation(this.Add, 10, 10);
            Console.WriteLine(a);

            if (Event != null)
            {
                Event(this, new EventArgs());
            }
        }
        public int Operation(MyDelegate myDelegate, int x, int y)
        {
            return myDelegate(x, y);
        }
        private public int Add(int x, int y)
        {
            return x + y;
        }
    }
}


