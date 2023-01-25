using MongoDB.Driver;

namespace BooksStore.Core
{
   public  interface IDbClient
    {

        IMongoCollection<Book> GetBooksCollection();
    }
}
