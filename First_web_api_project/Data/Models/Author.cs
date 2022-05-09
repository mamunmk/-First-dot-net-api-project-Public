using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_web_api_project.Data.Models
{
    public class Author
    {
        public int Id { get; set; }
        public string FullName { get; set; }

        //Navigation property. One to many relationship with Book_Author
        public List<Book_Author> Book_Authors { get; set; }
    }
}
