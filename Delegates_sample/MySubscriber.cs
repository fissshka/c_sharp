using System;
namespace MyDelegate
{
    public class Subscribe
    {
        public int SubID { get; set; }

        public MyPublisher Mypublisher { get; set; }
        public Subscribe(int subID, MyPublisher myPublisher)
        {
            this.Mypublisher = myPublisher;
            this.SubID = subID;
            myPublisher.Event += myPublisher_Event;
            myPublisher.A = 10;
        }
        private void MyPublisher_Event(object sender, EventArgs eventArgs)
        {
            Console.WriteLine($"Event handler is Subscriber (SubID)");
        }
        public void UnSub()
        {
        Mypublisher.Event -= MyPublisher_Event;
        }
}
}