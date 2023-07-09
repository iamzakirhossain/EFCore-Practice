using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models.FluentModels
{
    public class Fluent_Author
    {
        //[Key]
        public int Author_Id { get; set; }

        //[Required]
       // [MaxLength(50)]
        public string? FirstName { get; set; }

        //[Required]
        public string? LastName { get; set;}
        public DateTime BirthDate { get; set; }
        public string? Location { get; set; }

        //[NotMapped]
        public string? FullName
        {
            get
            {
                return $"{FirstName} {LastName}";
            }
        }
        //Many to Many (For above .NET 5)
        //public ICollection<Fluent_Book>? Books { get; set; }

        //Many to Many (For bellow .NET 5)
        public ICollection<Fluent_AuthorBook>? AuthorBooks { get; set; }
    }
}
