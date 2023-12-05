using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2.mymodels
{
    public class Author
    {
        [Key]
        public int Auth_id { get; set; }
        [Required]
        public string Username { get; set; }
        [NotMapped]
        public string Password { get; set; }
        [Required]
        public string Email { get; set; }
        public int age { get; set; }
        public virtual List<Post> posts_auth { get; set; } = new List<Post>();

    }
}
