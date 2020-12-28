using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CloneTheme.Models
{
    public class Comment
    {
        public int CommentId { get; set; }
        public string Comments { get; set; }
       public Post Post { get; set; }
        public int PostId { get; set; }
        public Customer Customer { get;set; }

    }
}
