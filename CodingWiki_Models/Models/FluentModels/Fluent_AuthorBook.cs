using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models.FluentModels
{
    public class Fluent_AuthorBook
    {
       // [ForeignKey(nameof(Author))]
        public int Author_Id { get; set; }
        public Fluent_Author? Author { get; set; }

        //[ForeignKey(nameof(Book))]
        public int Book_Id { get; set; }
        public Fluent_Book? Book { get; set; }
    }
}
