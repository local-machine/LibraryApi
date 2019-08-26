using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApi.Models
{
    [Table("authors")]
    public class Author
    {
        [Key]
        public int AuthorId { get; set; }
        public string Name { get; set; }
        public virtual ICollection<AuthorBook> Books { get; set; }

        public Author()
        {
            this.Books = new HashSet<AuthorBook>();
        }
 
    }
}