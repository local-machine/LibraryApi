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
        // public ActionResult Index()
        // {
        //     return _db.Books.ToList();
        // }

        // public ActionResult Create()
        // {
        //     ViewBag.AuthorId = new SelectList(_db.Authors, "AuthorId", "Name");
        //     return View();
        // }

        // public ActionResult Details(int id)
        // {
        //     var thisBook = _db.Books
        //     .Include(book => book.Authors)
        //     .ThenInclude(join => join.Author)
        //     .FirstOrDefault(book => book.BookId == id);
        //     return (thisBook);
        // }
        // GET api/books
        [HttpGet]
        public ActionResult<IEnumerable<Book>> GetAll()
        {
             // return _db.Books.ToList();
            return _db.Books
            .Include(x => x.Authors)
            .ThenInclude(join => join.Author)
            .OrderBy(x => x.Title).ToList();
        }

        // GET api/books/5
        [HttpGet("{id}")]
        public ActionResult<Book> Get(int id)
        {
            // var thisBook = _db.Books.FirstOrDefault(x => x.BookId == id);
            // return thisBook;
            return _db.Books
            .Include(x => x.Authors)
            .ThenInclude(join => join.Author)
            .FirstOrDefault(x => x.BookId == id);
        }

        // POST api/books
        [HttpPost]
        public void Post([FromBody] Book book)
        {
            _db.Books.Add(book);
            _db.SaveChanges();
        }

        // POST api/books/5
        [HttpPost("{id}")]
        public void Post(int id, [FromBody] Book book)
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

        // POST api/Books/1/Author/3
        [HttpPost("{bookId}/author/{authorId}")]
        public void AddAuthor(int bookId, int authorId)
        {
            _db.AuthorBooks.Add(new AuthorBook() { BookId = bookId, AuthorId = authorId });
            _db.SaveChanges();
        }
    }
}