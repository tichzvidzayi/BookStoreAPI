
using Microsoft.Extensions.Options;
using MongoDB.Driver;

namespace BooksStore.Core
{
    public class DBClient : IDbClient
    {
        private readonly IMongoCollection<Book> books;
        public DBClient(IOptions<BookStoreDbSettings> bookstoreSettings)
        {  //ConnectionString
           // var client = new MongoClient(bookstoreSettings.Value.ConnectionString);
           // if (client == null)
           // {
      //      "DATABASE_NAME": "Booksdb",
     //   "BOOKS_COLLECTION_NAME" : "Books"

          



            var settings = MongoClientSettings.FromConnectionString("mongodb+srv://tichzvidz:<posswords>@cluster0.wqfhhdh.mongodb.net/?retryWrites=true&w=majority");
            var client = new MongoClient(settings);
            var database = client.GetDatabase("booksdb");




            //  }
            //  var database = client.GetDatabase(bookstoreSettings.Value.DATABASE_NAME);
            books = database.GetCollection<Book>(bookstoreSettings.Value.BOOKS_COLLECTION_NAME);
          //("mongodb+srv://<tich>:<password2023>@cluster0.8a8bb.mongodb.net/Booksdb?retryWrites=true&w=majority");

        }
        public IMongoCollection<Book> GetBooksCollection()
        {
            return books;
        }
    }
}
