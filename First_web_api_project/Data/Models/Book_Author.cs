using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_web_api_project.Data.Models
{
    public class Book_Author
    {
        public int Id { get; set; }

        //Navigation property. Relation with Book model
        public int BookId { get; set; }
        public Book Book { get; set; }

        //Navigation property. Relation with Author model
        public int AuthorId { get; set; }
        public Author Author { get; set; }
    }
}
