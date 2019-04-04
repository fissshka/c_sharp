using System;

namespace Hello_Events_lect
{
    public class MyCustomSubscriber
    {
        private readonly int _instanceIndex;
        private readonly MyCustomPublisher _publisher;

        public MyCustomSubscriber(int instanceIndex, MyCustomPublisher publisher)
        {
            _instanceIndex = instanceIndex;
            this._publisher = publisher;
        }

        public void Subscribe()
        {
            this._publisher.CoolEvent += PublisherOnCoolEvent;
        }

        public void Unsubscribe()
        {
            this._publisher.CoolEvent -= PublisherOnCoolEvent;
        }

        private void PublisherOnCoolEvent(object sender, MyCustomEventArgs eventArgs)
        {
            Console.WriteLine($"OHHH MY GOD EVENT FIRED ON {eventArgs}");
            Console.WriteLine($"EVENT HANDLED FROM #{this._instanceIndex}");
        }
    }
}
