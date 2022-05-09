using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_web_api_project.Data.Models
{
    public class Publisher
    {
        public int Id { get; set; }
        public string Name { get; set; }

        //Navigation property for ralation with Book model
        public List<Book> Books { get; set; }
    }
}
