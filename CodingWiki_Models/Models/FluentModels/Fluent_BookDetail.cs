using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models.FluentModels
{
    public class Fluent_BookDetail
    {
        public int BookDetail_Id { get; set; }

        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; }
        public double Weight { get; set; }

        //[ForeignKey(nameof(Book))]
        public int Book_Id { get; set; }
        public Fluent_Book? Book { get; set; }
    }
}
