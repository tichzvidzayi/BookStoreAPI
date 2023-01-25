using BooksStore.Core;
using Microsoft.AspNetCore.Mvc;


namespace WookieBooks.WebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BooksController : ControllerBase
    {
        private readonly IBookServ bookServices;
        public BooksController(IBookServ bk_services)
        {
            bookServices = bk_services;
        }


        [HttpGet]
        public IActionResult GetBooks()
        {

            return Ok(bookServices.GetBooks());

        }


        [HttpGet("{id}", Name = "GetBook")]
        public IActionResult GetBooks(string id)
        {

            return Ok(bookServices.GetBook(id));

        }







        [HttpPost]

        public IActionResult AddBook(Book book)
        {

            bookServices.AddBook(book);
            // return Ok(book);
            return CreatedAtRoute("GetBook", new { id = book.Id }, book);

        }


        [HttpPut("{id}")]

        public IActionResult UpdateBook(Book book)
        {

            return Ok(bookServices.UpdateBook(book));

      
        }





        [HttpDelete("{id}")]

        public IActionResult DeleteBook(string id)
        {

            bookServices.DeleteBook(id);

            return NoContent();
        }





    }
}
