﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace First_web_api_project.Data.Models
{
    public class Book
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsRead { get; set; }
        public DateTime? DateRead { get; set; }
        public int? Rate { get; set; }
        public string Genre { get; set; }
        public string CoverUrl { get; set; }
        public DateTime DateAdded { get; set; }

        //Navigation property. One to many relationship with Publisher model
        public int PublisherId { get; set; }
        public Publisher Publisher { get; set; }

        //Navigation property. One to many relationship with Book_Author
        public List<Book_Author> Book_Authors { get; set; }
    }
}
