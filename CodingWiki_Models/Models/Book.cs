using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class Book
    {
        public int BookId { get; set; }
       
        public string? Title { get; set; }
        [MaxLength(20)]
        [Required]
        public string? ISBN { get; set; }
        public decimal Price { get; set; }

        [NotMapped]
        public string? PriceRange { get; set; }

        public BookDetail? BookDetail { get; set; }


        //One to Many
        [ForeignKey(nameof(Publisher))]
        public int PublisherId { get; set; }
        public Publisher? Publisher { get; set; }

        //Many to Many (For above .NET 5)
        //public ICollection<Author>? Authors { get; set; }

        //Many to Many (For bellow .NET 5)
        public ICollection<AuthorBook>? AuthorBooks { get; set; }

    }
}
