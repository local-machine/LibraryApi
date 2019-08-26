using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace LibraryApi.Models
{
    [Table("copies")]
    public class Copy
    {
        [Key]
        public int CopyId { get; set; }
        
        public int BookId { get; set; }
        public virtual Book Book { get; set; }

 
    }
}