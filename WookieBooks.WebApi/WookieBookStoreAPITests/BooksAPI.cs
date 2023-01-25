//using NUnit.Framework;
using System.Collections.Generic;
using System.Net.Http;
using System.Threading.Tasks;

namespace WookieBookStoreAPITests
{
    public class BooksAPI
    {
        private HttpClient restCl = new HttpClient();
        private string URI = "127.0.0.1/4489 ";

        public async Task<string> GetBook()
        {
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml,application/xml");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("AcceptEncoding", "gzip,deflate");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 text/html,application/xhtml,application/xml");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");

            var response = await restCl.GetAsync(URI);

            return response.ReasonPhrase.ToString();


        }

        public async Task<string> AddBook()
        {
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml,application/xml");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("AcceptEncoding", "gzip,deflate");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 text/html,application/xhtml,application/xml");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");
            var strcontent = new StringContent("Author: Alice Bob");
/*
            var book = new Book();
            book.Name = "John Doe";
            book.Id = "345";

            var json = Newtonsoft.Json.JsonConvert.SerializeObject(person);
            var data = new System.Net.Http.StringContent(json, Encoding.UTF8, "application/json");
*/

            var response = await restCl.PostAsync(URI, strcontent);

            return response.ReasonPhrase.ToString();


        }

        public async Task<string> UpdateBook()
        {
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml,application/xml");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("AcceptEncoding", "gzip,deflate");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 text/html,application/xhtml,application/xml");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");

            var strcontent = new FormUrlEncodedContent(new[]
           {
                new KeyValuePair<string, string>("Author ", "Alice Bob")
            });

         //   var response = await restCl.PostAsync(URI, strcontent);
            var response = await restCl.PutAsync(URI, strcontent);

            return response.ReasonPhrase.ToString();
        }
        public async Task<string> DeleteBook()
        {
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("Accept", "text/html,application/xhtml,application/xml");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("AcceptEncoding", "gzip,deflate");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("User-Agent", "Mozilla/5.0 text/html,application/xhtml,application/xml");
            restCl.DefaultRequestHeaders.TryAddWithoutValidation("Accept-Charset", "ISO-8859-1");

            var response = await restCl.DeleteAsync(URI);

            return response.ReasonPhrase.ToString();


        }

    }
}