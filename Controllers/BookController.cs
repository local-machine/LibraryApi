using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using LibraryApi.Models;

namespace LibraryApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BooksController : ControllerBase
    {
        private LibraryContext _db = new LibraryContext();
        // GET api/books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> Get()
        {
            return _db.Books.ToList();
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            var thisBook = _db.Books.FirstOrDefault(x => x.BookId == id);
            return thisBook;
        }

        // POST api/books
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
        }

        // PUT api/books/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Book book)
        {
            book.BookId = id;
            _db.Entry(book).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/books/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var bookToDelete = _db.Books.FirstOrDefault(x => x.BookId == id);
            _db.Books.Remove(bookToDelete);
            _db.SaveChanges();
        }
    }
}