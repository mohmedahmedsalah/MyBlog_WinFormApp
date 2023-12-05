using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFD2.mymodels
{
    public class Catalog
    {
        [Key]
       public int Cat_id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }

        public virtual List<Post> posts_cat { get; set; } = new List<Post>();

    }
}
