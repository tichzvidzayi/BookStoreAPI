using MongoDB.Driver;
using System;
using System.Collections.Generic;

namespace BooksStore.Core
{
    public class BookServ : IBookServ
    {
        private readonly IMongoCollection<Book> books;
        public BookServ (IDbClient dbcl)
        {

            books = dbcl.GetBooksCollection();

        }

        public Book AddBook(Book book)
        {
            books.InsertOne(book);
            return book;
        }

        public void DeleteBook(string id)
        {
            books.DeleteOne(book => book.Id == id);
           // throw new NotImplementedException();
        }

        public Book GetBook(string id)
        {
            return books.Find(book => book.Id == id).First();
        }

        public List<Book> GetBooks()
        {
            return books.Find(book => true).ToList();
            /*
            return new List<Book>
            {

                new Book
                {
                  Author = "Tich Zvidzayi" ,
                  Price = "R8919",
                  CoverImage = "Image",
                  Description = "A good book",
                  Title = "Machines",
                  Id = "AQ2390K0089GTF"

                }
            };
           */
           // throw new NotImplementedException();
        }

        public Book UpdateBook(Book book)
        {
            GetBook(book.Id);
            books.ReplaceOne(i => i.Id == book.Id, book);
            return book;
        }
    }
}
