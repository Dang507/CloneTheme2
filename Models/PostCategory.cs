using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public class PostCategory
    {

        public int PostId { get; set; }
        public int CategoryId {  get; set; }
        public Post Post { get; set; }
        public Category Category { get; set; }

    }
}
