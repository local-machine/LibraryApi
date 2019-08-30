using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApi.Models
{
    [Table("books")]
    public class Book
    {
        [Key]
        public int BookId { get; set; }
        public string Title { get; set; }
        public string Genre { get; set; }

        public virtual ICollection<AuthorBook> Authors { get; set; }




        public Book()
        {
            this.Authors = new HashSet<AuthorBook>();
        }
 
    }
}