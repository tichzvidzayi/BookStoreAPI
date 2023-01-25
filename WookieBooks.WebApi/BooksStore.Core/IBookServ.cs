using System.Collections.Generic;

namespace BooksStore.Core
{
   public interface IBookServ
    {
        List<Book> GetBooks();
        Book GetBook(string id);
        Book AddBook(Book book);
        Book UpdateBook(Book book);
        //Delete book
        void DeleteBook(string id);

    }
}
