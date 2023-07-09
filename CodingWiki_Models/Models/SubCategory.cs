using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingWiki_Models.Models
{
    public class SubCategory
    {
        public int SubCategoryId { get; set; }
        [Required]
        [MaxLength(50)]
        public string? Name { get; set; }    
    }
}
