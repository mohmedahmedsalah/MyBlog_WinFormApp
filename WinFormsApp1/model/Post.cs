using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
namespace EFD2.mymodels
{
    public class Post
    {
        
        public int Id { get;  set; }
        [Required]
        [MaxLength(25)]
        public string Title { get; set; }
        [MaxLength(50)]
        public string Bref{ get; set; }
        [MaxLength(100)]
        public string Description { get; set; }
        [Required]
        public DateTime Time { get; set; }
        [Required]
        public DateTime Date { get; set; }
        
        [ForeignKey("Author")]
        public int Auth_id { get; set; }
        
        [ForeignKey("Catalog")]
        public int Cat_id { get; set; }

        Author author { get; set; }
        Catalog catalog { get; set; }

    }
}
