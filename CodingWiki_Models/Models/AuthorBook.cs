﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class AuthorBook
    {
        [ForeignKey(nameof(Author))]
        public int AuthorId { get; set; }
        public Author? Author { get; set; }

        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}
