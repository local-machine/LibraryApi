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
    public class CopiesController : ControllerBase
    {
        private LibraryContext _db = new LibraryContext();
        // GET api/copies
        [HttpGet]
        public ActionResult<IEnumerable<Copy>> Get()
        {
            return _db.Copies.ToList();
        }

        // GET api/copies/5
        [HttpGet("{id}")]
        public ActionResult<Copy> Get(int id, bool Available)
        {
            var thisCopy = _db.Copies.FirstOrDefault(x => x.CopyId == id);
            return thisCopy;
        }

        // POST api/Copys
        [HttpPost]
        public void Post([FromBody] Copy copy)
        {
            _db.Copies.Add(copy);
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