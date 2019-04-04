using System;
using System.Linq;

namespace CSharp_Net_module1_2_1_lab
{

    // 1) declare interface ILibraryUser
    // declare method's signature for methods of class LibraryUser



    // 2) declare class LibraryUser, it implements ILibraryUser


    // 3) declare properties: FirstName (read only), LastName (read only), 
    // Id (read only), Phone (get and set), BookLimit (read only)
 
    // 4) declare field (bookList) as a string array

 
    // 5) declare indexer BookList for array bookList
 
    // 6) declare constructors: default and parameter
 
    // 7) declare methods: 

        //AddBook() – add new book to array bookList
 
        //RemoveBook() – remove book from array bookList
 
        //BookInfo() – returns book info by index
 
        //BooksCout() – returns current count of books


    public class LibraryUser
    {
        private readonly string[] bookList;

        public LibraryUser()
        {
            this.bookList = new string[0];
        }

        public LibraryUser(string firstName, string lastName, string phone, int bookLimit)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Phone = phone;
            this.BookLimit = bookLimit;
            this.bookList = new string[bookLimit];
        }

        public string this[int index]
        {
            get { return this.bookList[index]; }
            set { this.bookList[index] = value; }
        }

        public int Id { get; private set; }

        public string FirstName { get; private set; }

        public string LastName { get; private set; }

        public string Phone { get; set; }

        public int BookLimit { get; private set; }

        public void AddBook(string book)
        {
            for (int i = 0; i < this.bookList.Length; i++)
            {
                if (string.IsNullOrEmpty(this.bookList[i]))
                {
                    this.bookList[i] = book;
                    break;
                }
            }
        }

        public void RemoveBook(string book)
        {
            for (int i = 0; i < this.bookList.Length; i++)
            {
                if (this[i] == book)
                {
                    this[i] = string.Empty;
                }
            }
        }

        public string BookInfo(string book)
        {
            for (int i = 0; i < this.bookList.Length; i++)
            {
                if (this[i] == book)
                {
                    return this[i];
                }
            }

            return null;
        }

        public int BooksCount()
        {
            int count = 0;
            for (int i = 0; i < this.bookList.Length; i++)
            {
                if (string.IsNullOrEmpty(this[i]))
                {
                    continue;
                }

                count++;
            }

            return count;
        }
    }
}
