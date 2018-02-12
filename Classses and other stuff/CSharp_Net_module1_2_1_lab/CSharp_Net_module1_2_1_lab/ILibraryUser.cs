using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_Net_module1_2_1_lab
{
        public interface ILibraryUser
        {
            void AddBook(string AddedBook);
            void RemoveBook(string RemovedBook);
            string BookInfo(int BookIndex);
            int BooksCount();
        }
}
