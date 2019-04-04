using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritancePolymorphism
{
    // Example 8 - 2 Interfaces implementation

    interface IPrintedBook
    {
        int Pages { get; }
        void Publish();
    }

    interface IEBook
    {
        int Pages { get; }
        void Publish();
    }

    class Book : IPrintedBook, IEBook
    {
        public int Pages { get; private set; }
        public Book(int pages)
        {
            this.Pages = pages;
        }

        public void Publish()
        {
            Console.WriteLine("Book is publishing...");
        }

        public void MethodFromBook()
        {

        }

        // Example 9 - explicit interface implementation
        void IPrintedBook.Publish()
        {
            Console.WriteLine("Book is printing...");
        }

        void IEBook.Publish()
        {
            Console.WriteLine("Book is uploading...");
        }

    }
}
