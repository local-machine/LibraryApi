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
    public class AuthorsController : ControllerBase
    {
        private LibraryContext _db = new LibraryContext();
        // GET api/authors
        [HttpGet]
        public ActionResult<IEnumerable<Author>> Get()
        {
            return _db.Authors.ToList();
        }

        // GET api/authors/5
        [HttpGet("{id}")]
        public ActionResult<Author> Get(int id)
        {
            var thisAuthor = _db.Authors.FirstOrDefault(x => x.AuthorId == id);
            return thisAuthor;
        }

        // POST api/authors
        [HttpPost]
        public void Post([FromBody] Author author)
        {
            _db.Authors.Add(author);
            _db.SaveChanges();
        }

        // PUT api/authors/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Author author)
        {
            author.AuthorId = id;
            _db.Entry(author).State = EntityState.Modified;
            _db.SaveChanges();
        }

        // DELETE api/authors/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            var authorToDelete = _db.Authors.FirstOrDefault(x => x.AuthorId == id);
            _db.Authors.Remove(authorToDelete);
            _db.SaveChanges();
        }
    }
}