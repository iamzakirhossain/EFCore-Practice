using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.Contracts;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class BookDetail
    {
        [Key]
        public int BookDetailId { get; set; }

        [Required]
        public int NumberOfChapters { get; set; }
        public int NumberOfPages { get; set; }
        public double Weight { get; set; }

        [ForeignKey(nameof(Book))]
        public int BookId { get; set; }
        public Book? Book { get; set; }
    }
}
