using System;

namespace CSharp_Net_module1_2_1_lab
{

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser
    // 2) declare class LibraryUser, it implements ILibraryUser
    public class LibraryUser : ILibraryUser
    {
        // 3) declare properties: FirstName (read only), LastName (read only), 
        // Id (read only), Phone (get and set), BookLimit (read only)
        //properties
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        public int Id { get; private set; }
        public string Phone { get; set; }
        public int BookLimit { get; private set; }

        // 4) declare field (bookList) as a string array
        private string[] bookList;
 

        // 5) declare indexer BookList for array bookList
        //static int BookListInd;
        public string this[int BookListInd]
        {
            get { return this.bookList[BookListInd]; }
            set { this.bookList[BookListInd] = value; }
        }

        // 6) declare constructors: default and parameter
        public LibraryUser()
        {
            FirstName = "Jane";
            LastName = "Doe";
            Id = 0;
            Phone = "+380665239585";
            BookLimit = 3;
            //bookList = new string[BookListInd];
        }
        //contructor paremetrised
        public LibraryUser(string FirstName, string LastName, int Id, string Phone, int BookLimit)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Id = Id;
            this.Phone = Phone;
            this.BookLimit = BookLimit;
            //bookList = new string[BookListInd];
        }
        //method adding new book to array bookList
        public void AddBook(string Books)
        {
            for (int i = 0; i < this.bookList.Length; i++)
            {
                if (string.IsNullorEmpty(this.bookList[i]))
            {
                    this.bookList == Book;
                    {

                    }
            }
            }
            //if(BookListInd > BookLimit)
            //{

           //    Console.WriteLine("Sorry, you cannot add more books");
           // }
            //else BookListInd++;
            //BookListInd++;
            //bookList[BookListInd] = AddedBook;
            //Console.WriteLine("Book " + AddedBook + " has been added to user's account");
        }
        //method deleting book from array bookList
        public void RemoveBook(string RemovedBook)
        {
        /*for (int i = 0; i < BookListInd; i++)
        {
            if (RemovedBook == bookList[i])
            {
                bookList[i] = bookList[BookListInd];
                BookListInd--;
            }
        }*/
        for (int i = 0; i < this.bookList.Length; i++)
        {
            if (this[i]=Book)
            {

        }
    }
        //method returning book info by index
        public string BookInfo(int BookIndex)
        {
            //if (BookIndex < BookListInd)
            //{
            //bookList[BookIndex] = bookList[BookListInd];
            //return bookList[BookListInd];
            return bookList[BookIndex];
            //}

            //else return message;

        }
        //method returning current count of books
        public int BooksCount()
        {
            return BookListInd;
        }

        public string BookInfo()
        {
            throw new NotImplementedException();
        }
        // 7) declare methods: 

        //AddBook() – add new book to array bookList

        //RemoveBook() – remove book from array bookList

        //BookInfo() – returns book info by index

        //BooksCout() – returns current count of books
    }
}



