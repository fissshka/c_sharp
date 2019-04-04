namespace CSharp_Net_module1_2_1_lab
{
    public interface ILibraryUser
    {
        void AddBook(string book); // – add new book to array bookList

        void RemoveBook(string book); // – remove book from array bookList

        string BookInfo(string book);  // -returns book info by index

        int BooksCount(); //– returns current count of books
    }
}
